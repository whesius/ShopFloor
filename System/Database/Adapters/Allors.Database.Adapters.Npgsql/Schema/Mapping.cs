// <copyright file="Mapping.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using Meta;
    using Npgsql;
    using NpgsqlTypes;
    using static Sql.Schema.MappingConstants;

    public class Mapping : Sql.Schema.IMapping
    {
        private readonly IDictionary<IRoleType, string> paramInvocationNameByRoleType;
        private readonly IDictionary<IClass, string> tableNameForObjectByClass;
        private readonly IDictionary<IRelationType, string> columnNameByRelationType;
        private readonly IDictionary<IRelationType, string> tableNameForRelationByRelationType;
        private readonly IDictionary<IClass, string> procedureNameForCreateObjectByClass;
        private readonly IDictionary<IClass, string> procedureNameForCreateObjectsByClass;
        private readonly IDictionary<IClass, string> procedureNameForDeleteObjectByClass;
        private readonly IDictionary<IClass, string> procedureNameForGetUnitRolesByClass;
        private readonly IDictionary<IClass, string> procedureNameForPrefetchUnitRolesByClass;
        private readonly IDictionary<IClass, IDictionary<IRelationType, string>> procedureNameForSetUnitRoleByRelationTypeByClass;
        private readonly IDictionary<IRelationType, string> procedureNameForGetRoleByRelationType;
        private readonly IDictionary<IRelationType, string> procedureNameForPrefetchRoleByRelationType;
        private readonly IDictionary<IRelationType, string> procedureNameForSetRoleByRelationType;
        private readonly IDictionary<IRelationType, string> procedureNameForAddRoleByRelationType;
        private readonly IDictionary<IRelationType, string> procedureNameForRemoveRoleByRelationType;
        private readonly IDictionary<IRelationType, string> procedureNameForClearRoleByRelationType;
        private readonly IDictionary<IRelationType, string> procedureNameForGetAssociationByRelationType;
        private readonly IDictionary<IRelationType, string> procedureNameForPrefetchAssociationByRelationType;

        public string ParamInvocationFormat => ParameterInvocationFormat;
        public string ParamInvocationNameForObject { get; }
        public string ParamInvocationNameForClass { get; }

        public IDictionary<IRoleType, string> ParamInvocationNameByRoleType => this.paramInvocationNameByRoleType;

        public string TableNameForObjects { get; }
        public IDictionary<IClass, string> TableNameForObjectByClass => this.tableNameForObjectByClass;
        public IDictionary<IRelationType, string> ColumnNameByRelationType => this.columnNameByRelationType;
        public IDictionary<IRelationType, string> TableNameForRelationByRelationType => this.tableNameForRelationByRelationType;

        public IDictionary<IClass, string> ProcedureNameForCreateObjectByClass => this.procedureNameForCreateObjectByClass;
        public IDictionary<IClass, string> ProcedureNameForCreateObjectsByClass => this.procedureNameForCreateObjectsByClass;
        public IDictionary<IClass, string> ProcedureNameForDeleteObjectByClass => this.procedureNameForDeleteObjectByClass;
        public IDictionary<IClass, string> ProcedureNameForGetUnitRolesByClass => this.procedureNameForGetUnitRolesByClass;
        public IDictionary<IClass, string> ProcedureNameForPrefetchUnitRolesByClass => this.procedureNameForPrefetchUnitRolesByClass;
        public IDictionary<IClass, IDictionary<IRelationType, string>> ProcedureNameForSetUnitRoleByRelationTypeByClass => this.procedureNameForSetUnitRoleByRelationTypeByClass;
        public IDictionary<IRelationType, string> ProcedureNameForGetRoleByRelationType => this.procedureNameForGetRoleByRelationType;
        public IDictionary<IRelationType, string> ProcedureNameForPrefetchRoleByRelationType => this.procedureNameForPrefetchRoleByRelationType;
        public IDictionary<IRelationType, string> ProcedureNameForSetRoleByRelationType => this.procedureNameForSetRoleByRelationType;
        public IDictionary<IRelationType, string> ProcedureNameForAddRoleByRelationType => this.procedureNameForAddRoleByRelationType;
        public IDictionary<IRelationType, string> ProcedureNameForRemoveRoleByRelationType => this.procedureNameForRemoveRoleByRelationType;
        public IDictionary<IRelationType, string> ProcedureNameForClearRoleByRelationType => this.procedureNameForClearRoleByRelationType;
        public IDictionary<IRelationType, string> ProcedureNameForGetAssociationByRelationType => this.procedureNameForGetAssociationByRelationType;
        public IDictionary<IRelationType, string> ProcedureNameForPrefetchAssociationByRelationType => this.procedureNameForPrefetchAssociationByRelationType;

        public string StringCollation => string.Empty;
        public string Ascending => "ASC NULLS FIRST";
        public string Descending => "DESC NULLS LAST";

        public string ProcedureNameForInstantiate { get; private set; }
        public string ProcedureNameForGetVersion { get; private set; }
        public string ProcedureNameForUpdateVersion { get; private set; }

        internal const string SqlTypeForClass = "uuid";
        internal const string SqlTypeForObject = "bigint";
        internal const string SqlTypeForVersion = "bigint";
        private const string SqlTypeForCount = "integer";

        internal const NpgsqlDbType NpgsqlDbTypeForClass = NpgsqlDbType.Uuid;
        internal const NpgsqlDbType NpgsqlDbTypeForObject = NpgsqlDbType.Bigint;
        internal const NpgsqlDbType NpgsqlDbTypeForCount = NpgsqlDbType.Integer;

        internal MappingArrayParameter ObjectArrayParam { get; }
        private MappingArrayParameter CompositeRoleArrayParam { get; }
        internal MappingArrayParameter StringRoleArrayParam { get; }
        private MappingArrayParameter StringMaxRoleArrayParam { get; }
        private MappingArrayParameter IntegerRoleArrayParam { get; }
        private MappingArrayParameter DecimalRoleArrayParam { get; }
        private MappingArrayParameter DoubleRoleArrayParam { get; }
        private MappingArrayParameter BooleanRoleArrayParam { get; }
        private MappingArrayParameter DateTimeRoleArrayParam { get; }
        private MappingArrayParameter UniqueRoleArrayParam { get; }
        private MappingArrayParameter BinaryRoleArrayParam { get; }

        private string ParamNameForAssociation { get; }
        private string ParamNameForCompositeRole { get; }
        private string ParamNameForCount { get; }
        private string ParamNameForObject { get; }
        private string ParamNameForClass { get; }

        public string ParamInvocationNameForAssociation { get; }
        public string ParamInvocationNameForCompositeRole { get; }
        public string ParamInvocationNameForCount { get; }

        public string ObjectArrayParamInvocationName => this.ObjectArrayParam.InvocationName;

        public string CompositeRoleArrayParamInvocationName => this.StringRoleArrayParam.InvocationName;

        private const string ProcedurePrefixForInstantiate = "i";
        private const string ProcedurePrefixForGetVersion = "gv";
        private const string ProcedurePrefixForUpdateVersion = "uv";
        private const string ProcedurePrefixForCreateObject = "co_";
        private const string ProcedurePrefixForCreateObjects = "cos_";
        private const string ProcedurePrefixForDeleteObject = "do_";
        private const string ProcedurePrefixForLoad = "l_";
        private const string ProcedurePrefixForGetUnits = "gu_";
        private const string ProcedurePrefixForPrefetchUnits = "pu_";
        private const string ProcedurePrefixForGetRole = "gc_";
        private const string ProcedurePrefixForPrefetchRole = "pc_";
        private const string ProcedurePrefixForSetRole = "sc_";
        private const string ProcedurePrefixForClearRole = "cc_";
        private const string ProcedurePrefixForAddRole = "ac_";
        private const string ProcedurePrefixForRemoveRole = "rc_";
        private const string ProcedurePrefixForGetAssociation = "ga_";
        private const string ProcedurePrefixForPrefetchAssociation = "pa_";

        internal const string ParameterFormat = "p_{0}";
        private const string ParameterInvocationFormat = ":p_{0}";

        public Mapping(Database database)
        {
            this.Database = database;

            this.ParamInvocationNameForObject = string.Format(ParameterInvocationFormat, ColumnNameForObject);
            this.ParamInvocationNameForClass = string.Format(ParameterInvocationFormat, ColumnNameForClass);

            this.ParamNameForAssociation = string.Format(ParameterFormat, ColumnNameForAssociation);
            this.ParamNameForCompositeRole = string.Format(ParameterFormat, ColumnNameForRole);
            this.ParamNameForCount = string.Format(ParameterFormat, "count");
            this.ParamNameForObject = string.Format(ParameterFormat, ColumnNameForObject);
            this.ParamNameForClass = string.Format(ParameterFormat, ColumnNameForClass);

            this.ParamInvocationNameForAssociation = string.Format(ParameterInvocationFormat, ColumnNameForAssociation);
            this.ParamInvocationNameForCompositeRole = string.Format(ParameterInvocationFormat, ColumnNameForRole);
            this.ParamInvocationNameForCount = string.Format(ParameterInvocationFormat, "count");

            this.ObjectArrayParam = new MappingArrayParameter(database, this, "arr_o", NpgsqlDbType.Bigint);
            this.CompositeRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Bigint);
            this.StringRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Varchar);
            this.StringMaxRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Text);
            this.IntegerRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Integer);
            this.DecimalRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Numeric);
            this.DoubleRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Double);
            this.BooleanRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Boolean);
            this.DateTimeRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.TimestampTz);
            this.UniqueRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Uuid);
            this.BinaryRoleArrayParam = new MappingArrayParameter(database, this, "arr_r", NpgsqlDbType.Bytea);

            // Tables
            // ------
            this.TableNameForObjects = database.SchemaName + "." + HashIdentifier("_o");
            this.tableNameForObjectByClass = new Dictionary<IClass, string>();
            this.columnNameByRelationType = new Dictionary<IRelationType, string>();
            this.paramInvocationNameByRoleType = new Dictionary<IRoleType, string>();

            foreach (var @class in this.Database.MetaPopulation.DatabaseClasses)
            {
                this.tableNameForObjectByClass.Add(@class, this.Database.SchemaName + "." + this.NormalizeName(@class.SchemaName));

                foreach (var associationType in @class.DatabaseAssociationTypes)
                {
                    var relationType = associationType.RelationType;
                    var roleType = relationType.RoleType;
                    if (!(associationType.IsMany && roleType.IsMany) && relationType.ExistExclusiveDatabaseClasses && roleType.IsMany)
                    {
                        this.columnNameByRelationType[relationType] = this.NormalizeName(associationType.SchemaName);
                    }
                }

                foreach (var roleType in @class.DatabaseRoleTypes)
                {
                    var relationType = roleType.RelationType;
                    var associationType3 = relationType.AssociationType;
                    if (roleType.ObjectType.IsUnit)
                    {
                        this.columnNameByRelationType[relationType] = this.NormalizeName(roleType.SchemaName);
                        this.paramInvocationNameByRoleType[roleType] = string.Format(ParameterInvocationFormat, roleType.SingularFullName);
                    }
                    else if (!(associationType3.IsMany && roleType.IsMany) && relationType.ExistExclusiveDatabaseClasses && !roleType.IsMany)
                    {
                        this.columnNameByRelationType[relationType] = this.NormalizeName(roleType.SchemaName);
                    }
                }
            }

            this.tableNameForRelationByRelationType = new Dictionary<IRelationType, string>();

            foreach (var relationType in this.Database.MetaPopulation.DatabaseRelationTypes)
            {
                var associationType = relationType.AssociationType;
                var roleType = relationType.RoleType;

                if (!roleType.ObjectType.IsUnit && ((associationType.IsMany && roleType.IsMany) || !relationType.ExistExclusiveDatabaseClasses))
                {
                    this.tableNameForRelationByRelationType.Add(relationType, this.Database.SchemaName + "." + this.NormalizeName(relationType.SchemaName));
                }
            }

            // Procedures
            // ----------
            this.ProcedureDefinitionByName = new Dictionary<string, string>();

            this.procedureNameForCreateObjectByClass = new Dictionary<IClass, string>();
            this.procedureNameForCreateObjectsByClass = new Dictionary<IClass, string>();
            this.procedureNameForDeleteObjectByClass = new Dictionary<IClass, string>();

            this.procedureNameForGetUnitRolesByClass = new Dictionary<IClass, string>();
            this.procedureNameForPrefetchUnitRolesByClass = new Dictionary<IClass, string>();
            this.procedureNameForSetUnitRoleByRelationTypeByClass = new Dictionary<IClass, IDictionary<IRelationType, string>>();

            this.procedureNameForGetRoleByRelationType = new Dictionary<IRelationType, string>();
            this.procedureNameForPrefetchRoleByRelationType = new Dictionary<IRelationType, string>();
            this.procedureNameForSetRoleByRelationType = new Dictionary<IRelationType, string>();
            this.procedureNameForAddRoleByRelationType = new Dictionary<IRelationType, string>();
            this.procedureNameForRemoveRoleByRelationType = new Dictionary<IRelationType, string>();
            this.procedureNameForClearRoleByRelationType = new Dictionary<IRelationType, string>();
            this.procedureNameForGetAssociationByRelationType = new Dictionary<IRelationType, string>();
            this.procedureNameForPrefetchAssociationByRelationType = new Dictionary<IRelationType, string>();

            this.Instantiate();
            this.GetVersionIds();
            this.UpdateVersionIds();

            foreach (var @class in this.Database.MetaPopulation.DatabaseClasses)
            {
                this.LoadObjects(@class);
                this.CreateObject(@class);
                this.CreateObjects(@class);
                this.DeleteObject(@class);

                if (this.Database.GetSortedUnitRolesByObjectType(@class).Length > 0)
                {
                    this.GetUnitRoles(@class);
                    this.PrefetchUnitRoles(@class);
                }

                foreach (var associationType in @class.DatabaseAssociationTypes)
                {
                    if (!(associationType.IsMany && associationType.RoleType.IsMany) && associationType.RelationType.ExistExclusiveDatabaseClasses && associationType.RoleType.IsMany)
                    {
                        this.GetCompositesRoleObjectTable(@class, associationType);
                        this.PrefetchCompositesRoleObjectTable(@class, associationType);

                        if (associationType.IsOne)
                        {
                            this.GetCompositeAssociationObjectTable(@class, associationType);
                            this.PrefetchCompositeAssociationObjectTable(@class, associationType);
                        }

                        this.AddCompositeRoleObjectTable(@class, associationType);
                        this.RemoveCompositeRoleObjectTable(@class, associationType);
                        this.ClearCompositeRoleObjectTable(@class, associationType);
                    }
                }

                foreach (var roleType in @class.DatabaseRoleTypes)
                {
                    if (roleType.ObjectType.IsUnit)
                    {
                        this.SetUnitRoleType(@class, roleType);
                    }
                    else if (!(roleType.AssociationType.IsMany && roleType.IsMany) && roleType.RelationType.ExistExclusiveDatabaseClasses && roleType.IsOne)
                    {
                        this.GetCompositeRoleObjectTable(@class, roleType);
                        this.PrefetchCompositeRoleObjectTable(@class, roleType);

                        if (roleType.AssociationType.IsOne)
                        {
                            this.GetCompositeAssociationOne2OneObjectTable(@class, roleType);
                            this.PrefetchCompositeAssociationObjectTable(@class, roleType);
                        }
                        else
                        {
                            this.GetCompositesAssociationMany2OneObjectTable(@class, roleType);
                            this.PrefetchCompositesAssociationMany2OneObjectTable(@class, roleType);
                        }

                        this.SetCompositeRole(@class, roleType);
                        this.ClearCompositeRole(@class, roleType);
                    }
                }
            }

            foreach (var relationType in this.Database.MetaPopulation.DatabaseRelationTypes)
            {
                if (!relationType.RoleType.ObjectType.IsUnit && ((relationType.AssociationType.IsMany && relationType.RoleType.IsMany) || !relationType.ExistExclusiveDatabaseClasses))
                {
                    if (relationType.RoleType.IsMany)
                    {
                        this.GetCompositesRoleRelationTable(relationType);
                        this.PrefetchCompositesRoleRelationTable(relationType);
                        this.AddCompositeRoleRelationTable(relationType);
                        this.RemoveCompositeRoleRelationTable(relationType);
                    }
                    else
                    {
                        this.GetCompositeRoleRelationTable(relationType);
                        this.PrefetchCompositeRoleRelationType(relationType);
                        this.SetCompositeRoleRelationType(relationType);
                    }

                    if (relationType.AssociationType.IsOne)
                    {
                        this.GetCompositeAssociationRelationTable(relationType);
                        this.PrefetchCompositeAssociationRelationTable(relationType);
                    }
                    else
                    {
                        this.GetCompositesAssociationRelationTable(relationType);
                        this.PrefetchCompositesAssociationRelationTable(relationType);
                    }

                    this.ClearCompositeRoleRelationTable(relationType);
                }
            }
        }

        internal Dictionary<string, string> ProcedureDefinitionByName { get; }

        protected internal Database Database { get; }

        internal static string HashIdentifier(string name)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(name));
            return "\"" + Convert.ToBase64String(bytes) + "\"";
        }

        internal string NormalizeName(string name) => HashIdentifier(name.ToLowerInvariant());

        public string RoleJoinAlias(IRoleType role) => HashIdentifier(role.SingularFullName + "_R");
        public string AssociationJoinAlias(IAssociationType association) => HashIdentifier(association.SingularFullName + "_A");
        public string RoleInstanceJoinAlias(IRoleType role) => HashIdentifier(role.SingularFullName + "_RC");
        public string AssociationInstanceJoinAlias(IAssociationType association) => HashIdentifier(association.SingularFullName + "_AC");

        internal string GetSqlType(IRoleType roleType)
        {
            var unit = (IUnit)roleType.ObjectType;
            switch (unit.Tag)
            {
                case UnitTags.String:
                    if (roleType.Size == -1 || roleType.Size > 4000)
                    {
                        return "text";
                    }

                    return "varchar(" + roleType.Size + ")";

                case UnitTags.Integer:
                    return "integer";

                case UnitTags.Decimal:
                    return "numeric(" + roleType.Precision + "," + roleType.Scale + ")";

                case UnitTags.Float:
                    return "double precision";

                case UnitTags.Boolean:
                    return "boolean";

                case UnitTags.DateTime:
                    return "timestamptz";

                case UnitTags.Unique:
                    return "uuid";

                case UnitTags.Binary:
                    return "bytea";

                default:
                    return "!UNKNOWN VALUE TYPE!";
            }
        }

        internal NpgsqlDbType GetNpgsqlDbType(IRoleType roleType)
        {
            var unit = (IUnit)roleType.ObjectType;
            switch (unit.Tag)
            {
                case UnitTags.String:
                    return NpgsqlDbType.Varchar;

                case UnitTags.Integer:
                    return NpgsqlDbType.Integer;

                case UnitTags.Decimal:
                    return NpgsqlDbType.Numeric;

                case UnitTags.Float:
                    return NpgsqlDbType.Double;

                case UnitTags.Boolean:
                    return NpgsqlDbType.Boolean;

                case UnitTags.DateTime:
                    return NpgsqlDbType.TimestampTz;

                case UnitTags.Unique:
                    return NpgsqlDbType.Uuid;

                case UnitTags.Binary:
                    return NpgsqlDbType.Bytea;

                default:
                    throw new Exception("Unknown Unit Type");
            }
        }

        private void LoadObjects(IClass @class)
        {
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForClass},{this.ObjectArrayParam.TypeName})";
            var funcParams = $@"(
	{this.ParamNameForClass} {SqlTypeForClass},
	{this.ObjectArrayParam} {this.ObjectArrayParam.TypeName})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"INSERT INTO  {table} ({ColumnNameForClass}, {ColumnNameForObject})
    SELECT p_c, o
    FROM unnest(p_arr_o) AS t(o)";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForLoad + @class.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void CreateObject(IClass @class)
        {
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForClass})";
            var funcParams = $"({this.ParamNameForClass} {SqlTypeForClass})";
            var funcReturns = $"RETURNS {SqlTypeForObject}";
            var funcBody = $@"DECLARE {this.ParamNameForObject} {SqlTypeForObject};
BEGIN

    INSERT INTO {this.TableNameForObjects} ({ColumnNameForClass}, {ColumnNameForVersion})
    VALUES ({this.ParamNameForClass}, {(long)Allors.Version.DatabaseInitial})
    RETURNING {ColumnNameForObject} INTO {this.ParamNameForObject};

    INSERT INTO {table} ({ColumnNameForObject},{ColumnNameForClass})
    VALUES ({this.ParamNameForObject},{this.ParamNameForClass});

    RETURN {this.ParamNameForObject};
END";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForCreateObject + @class.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForCreateObjectByClass.Add(@class, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE plpgsql
AS $$
{funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void CreateObjects(IClass @class)
        {
            var dropArgs = $"({SqlTypeForClass}, {SqlTypeForCount})";
            var funcParams = $"({this.ParamNameForClass} {SqlTypeForClass}, {this.ParamNameForCount} {SqlTypeForCount})";
            var funcReturns = $"RETURNS SETOF {SqlTypeForObject}";
            var funcBody = $@"DECLARE ID integer;
DECLARE COUNTER integer := 0;
BEGIN
    WHILE COUNTER < {this.ParamNameForCount} LOOP

        INSERT INTO {this.TableNameForObjects} ({ColumnNameForClass}, {ColumnNameForVersion})
        VALUES ({this.ParamNameForClass}, {(long)Allors.Version.DatabaseInitial} )
        RETURNING {ColumnNameForObject} INTO ID;

        INSERT INTO {this.tableNameForObjectByClass[@class.ExclusiveDatabaseClass]} ({ColumnNameForObject},{ColumnNameForClass})
        VALUES (ID,{this.ParamNameForClass});

        COUNTER := COUNTER+1;

        RETURN NEXT ID;
    END LOOP;
END";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForCreateObjects + @class.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForCreateObjectsByClass.Add(@class, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE plpgsql
AS $$
{funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void DeleteObject(IClass @class)
        {
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForObject} {SqlTypeForObject})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"DELETE FROM {this.TableNameForObjects}
    WHERE {ColumnNameForObject}={this.ParamNameForObject};

    DELETE FROM {table}
    WHERE {ColumnNameForObject}={this.ParamNameForObject};";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForDeleteObject + @class.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForDeleteObjectByClass.Add(@class, name);

            var definition = $@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$

    {funcBody}
$$;
";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetUnitRoles(IClass @class)
        {
            var sortedUnitRoleTypes = this.Database.GetSortedUnitRolesByObjectType(@class);

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForObject} {SqlTypeForObject})";
            var funcReturns = $@"RETURNS TABLE
    ({string.Join(", ", sortedUnitRoleTypes.Select(v => $"{this.columnNameByRelationType[v.RelationType]} {this.GetSqlType(v)}"))})";
            var funcBody = $@"SELECT {string.Join(", ", sortedUnitRoleTypes.Select(v => this.columnNameByRelationType[v.RelationType]))}
    FROM {this.tableNameForObjectByClass[@class.ExclusiveDatabaseClass]}
    WHERE {ColumnNameForObject}={this.ParamNameForObject};";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetUnits + @class.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetUnitRolesByClass.Add(@class, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";
            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchUnitRoles(IClass @class)
        {
            var sortedUnitRoleTypes = this.Database.GetSortedUnitRolesByObjectType(@class);
            var table = this.tableNameForObjectByClass[@class.ExclusiveDatabaseClass];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
        {ColumnNameForObject} {SqlTypeForObject},
        {string.Join(", ", sortedUnitRoleTypes.Select(v => $"{this.columnNameByRelationType[v.RelationType]} {this.GetSqlType(v)}"))}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForObject}, {string.Join(", ", sortedUnitRoleTypes.Select(v => this.columnNameByRelationType[v.RelationType]))}
    FROM {table}
    WHERE {ColumnNameForObject} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchUnits + @class.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForPrefetchUnitRolesByClass.Add(@class, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositesRoleObjectTable(IClass @class, IAssociationType associationType)
        {
            var relationType = associationType.RelationType;
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForAssociation} {SqlTypeForObject})";
            var funcReturns = $"RETURNS SETOF {SqlTypeForObject}";
            var funcBody = $@"SELECT {ColumnNameForObject}
    FROM {table}
    WHERE {this.columnNameByRelationType[relationType]}={this.ParamNameForAssociation};";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositesRoleObjectTable(IClass @class, IAssociationType associationType)
        {
            var relationType = associationType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {this.columnNameByRelationType[relationType]} {SqlTypeForObject},
         {ColumnNameForObject} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {this.columnNameByRelationType[relationType]}, {ColumnNameForObject}
    FROM {table}
    WHERE {this.columnNameByRelationType[relationType]} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForPrefetchRoleByRelationType.Add(relationType, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";
            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositeAssociationObjectTable(IClass @class, IAssociationType associationType)
        {
            var relationType = associationType.RelationType;
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForCompositeRole} {SqlTypeForObject})";
            var funcReturns = $"RETURNS {SqlTypeForObject}";
            var funcBody = $@"DECLARE {this.ParamNameForAssociation} {SqlTypeForObject};
BEGIN
    SELECT {this.columnNameByRelationType[relationType]}
    FROM {table}
    WHERE {ColumnNameForObject}={this.ParamNameForCompositeRole}
    INTO {this.ParamNameForAssociation};

    RETURN {this.ParamNameForAssociation};
END";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetAssociation + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE plpgsql
AS $$
{funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositeAssociationObjectTable(IClass @class, IAssociationType associationType)
        {
            var relationType = associationType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {this.columnNameByRelationType[relationType]} {SqlTypeForObject},
         {ColumnNameForObject} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {this.columnNameByRelationType[relationType]}, {ColumnNameForObject}
    FROM {table}
    WHERE {ColumnNameForObject} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchAssociation + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForPrefetchAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void AddCompositeRoleObjectTable(IClass @class, IAssociationType associationType)
        {
            var relationType = associationType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;
            var roles = this.CompositeRoleArrayParam;
            var rolesType = roles.TypeName;

            var dropArgs = $"({objectsType}, {rolesType})";
            var funcParams = $"({objects} {objectsType}, {roles} {rolesType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH relations AS (SELECT UNNEST({objects}) AS {ColumnNameForAssociation}, UNNEST({roles}) AS {ColumnNameForRole})

    UPDATE {table}
    SET {this.columnNameByRelationType[relationType]} = relations.{ColumnNameForAssociation}
    FROM relations
    WHERE {table}.{ColumnNameForObject} = relations.{ColumnNameForRole}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForAddRole + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForAddRoleByRelationType.Add(relationType, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void RemoveCompositeRoleObjectTable(IClass @class, IAssociationType associationType)
        {
            var relationType = associationType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;
            var roles = this.CompositeRoleArrayParam;
            var rolesType = roles.TypeName;

            var dropArgs = $"({objectsType}, {rolesType})";
            var funcParams = $"({objects} {objectsType}, {roles} {rolesType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH relations AS (SELECT UNNEST({objects}) AS {ColumnNameForAssociation}, UNNEST({roles}) AS {ColumnNameForRole})

    UPDATE {table}
    SET {this.columnNameByRelationType[relationType]} = null
    FROM relations
    WHERE {table}.{this.columnNameByRelationType[relationType]} = relations.{ColumnNameForAssociation} AND
          {table}.{ColumnNameForObject} = relations.{ColumnNameForRole}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForRemoveRole + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForRemoveRoleByRelationType.Add(relationType, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void ClearCompositeRoleObjectTable(IClass @class, IAssociationType associationType)
        {
            var relationType = associationType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    UPDATE {table}
    SET {this.columnNameByRelationType[relationType]} = null
    FROM objects
    WHERE {table}.{this.columnNameByRelationType[relationType]} = objects.{ColumnNameForObject}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForClearRole + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForClearRoleByRelationType.Add(relationType, name);

            var definition =
                $@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void SetUnitRoleType(IClass @class, IRoleType roleType)
        {
            if (!this.procedureNameForSetUnitRoleByRelationTypeByClass.TryGetValue(@class, out var procedureNameForSetUnitRoleByRelationType))
            {
                procedureNameForSetUnitRoleByRelationType = new Dictionary<IRelationType, string>();
                this.procedureNameForSetUnitRoleByRelationTypeByClass.Add(@class, procedureNameForSetUnitRoleByRelationType);
            }

            var relationType = roleType.RelationType;
            var unitTypeTag = ((IUnit)relationType.RoleType.ObjectType).Tag;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            MappingArrayParameter roles;
            switch (unitTypeTag)
            {
                case UnitTags.String:
                    roles = this.StringMaxRoleArrayParam;
                    break;

                case UnitTags.Integer:
                    roles = this.IntegerRoleArrayParam;
                    break;

                case UnitTags.Float:
                    roles = this.DoubleRoleArrayParam;
                    break;

                case UnitTags.Decimal:
                    roles = this.DecimalRoleArrayParam;
                    break;

                case UnitTags.Boolean:
                    roles = this.BooleanRoleArrayParam;
                    break;

                case UnitTags.DateTime:
                    roles = this.DateTimeRoleArrayParam;
                    break;

                case UnitTags.Unique:
                    roles = this.UniqueRoleArrayParam;
                    break;

                case UnitTags.Binary:
                    roles = this.BinaryRoleArrayParam;
                    break;

                default:
                    throw new ArgumentException("Unknown Unit ObjectType: " + roleType.ObjectType.SingularName);
            }

            var rolesType = roles.TypeName;

            var dropArgs = $"({objectsType}, {rolesType})";
            var funcParams = $"({objects} {objectsType}, {roles} {rolesType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH relations AS (SELECT UNNEST({objects}) AS {ColumnNameForAssociation}, UNNEST({roles}) AS {ColumnNameForRole})

    UPDATE {table}
    SET {this.columnNameByRelationType[relationType]} = relations.{ColumnNameForRole}
    FROM relations
    WHERE {ColumnNameForObject} = relations.{ColumnNameForAssociation}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForSetRole + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            procedureNameForSetUnitRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";
            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositeRoleObjectTable(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForAssociation} {SqlTypeForObject})";
            var funcReturns = $"RETURNS {SqlTypeForObject}";
            var funcBody = $@"DECLARE {this.ParamNameForCompositeRole} {SqlTypeForObject};
BEGIN
    SELECT {this.columnNameByRelationType[relationType]}
    FROM {table}
    WHERE {ColumnNameForObject}={this.ParamNameForAssociation}
    INTO {this.ParamNameForCompositeRole};

    RETURN {this.ParamNameForCompositeRole};
END";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE plpgsql
AS $$
{funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositeRoleObjectTable(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {this.columnNameByRelationType[relationType]} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForObject}, {this.columnNameByRelationType[relationType]}
    FROM {table}
    WHERE {ColumnNameForObject} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForPrefetchRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositeAssociationOne2OneObjectTable(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForCompositeRole} {SqlTypeForObject})";
            var funcReturns = $"RETURNS {SqlTypeForObject}";
            var funcBody = $@"DECLARE {this.ParamNameForAssociation} {SqlTypeForObject};
BEGIN
    SELECT {ColumnNameForObject}
    FROM {table}
    WHERE {this.columnNameByRelationType[relationType]}={this.ParamNameForCompositeRole}
    INTO {this.ParamNameForAssociation};

    RETURN {this.ParamNameForAssociation};
END";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetAssociation + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE plpgsql
AS $$
{funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositeAssociationObjectTable(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {ColumnNameForAssociation} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForObject}, {this.columnNameByRelationType[relationType]}
    FROM {table}
    WHERE {this.columnNameByRelationType[relationType]} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchAssociation + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForPrefetchAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositesAssociationMany2OneObjectTable(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForCompositeRole} {SqlTypeForObject})";
            var funcReturns = $"RETURNS SETOF {SqlTypeForObject}";
            var funcBody = $@"SELECT {ColumnNameForObject}
    FROM {table}
    WHERE {this.columnNameByRelationType[relationType]}={this.ParamNameForCompositeRole};";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetAssociation + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositesAssociationMany2OneObjectTable(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {ColumnNameForAssociation} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForObject}, {this.columnNameByRelationType[relationType]}
    FROM {table}
    WHERE {this.columnNameByRelationType[relationType]} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchAssociation + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForPrefetchAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void SetCompositeRole(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;
            var roles = this.CompositeRoleArrayParam;
            var rolesType = roles.TypeName;

            var dropArgs = $"({objectsType}, {rolesType})";
            var funcParams = $"({objects} {objectsType}, {roles} {rolesType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH relations AS (SELECT UNNEST({objects}) AS {ColumnNameForAssociation}, UNNEST({roles}) AS {ColumnNameForRole})

    UPDATE {table}
    SET {this.columnNameByRelationType[relationType]} = relations.{ColumnNameForRole}
    FROM relations
    WHERE {ColumnNameForObject} = relations.{ColumnNameForAssociation}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForSetRole + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForSetRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void ClearCompositeRole(IClass @class, IRoleType roleType)
        {
            var relationType = roleType.RelationType;
            var table = this.tableNameForObjectByClass[@class];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    UPDATE {table}
    SET {this.columnNameByRelationType[relationType]} = null
    FROM objects
    WHERE {table}.{ColumnNameForObject} = objects.{ColumnNameForObject}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForClearRole + @class.Id.ToString("N") + "_" + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForClearRoleByRelationType.Add(relationType, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositesRoleRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForAssociation} {SqlTypeForObject})";
            var funcReturns = $"RETURNS SETOF {SqlTypeForObject}";
            var funcBody = $@"SELECT {ColumnNameForRole}
    FROM {table}
    WHERE {ColumnNameForAssociation}={this.ParamNameForAssociation};";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositesRoleRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objectsArray = this.ObjectArrayParam;
            var objectsArrayType = objectsArray.TypeName;

            var dropArgs = $"({objectsArrayType})";
            var funcParams = $"({objectsArray} {objectsArrayType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {ColumnNameForRole} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objectsArray}) AS {ColumnNameForObject})

    SELECT {ColumnNameForAssociation}, {ColumnNameForRole}
    FROM {table}
    WHERE {ColumnNameForAssociation} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForPrefetchRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void AddCompositeRoleRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;
            var roles = this.CompositeRoleArrayParam;
            var rolesType = roles.TypeName;

            var dropArgs = $"({objectsType}, {rolesType})";
            var funcParams = $"({objects} {objectsType}, {roles} {rolesType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH relations AS (SELECT UNNEST({objects}) AS {ColumnNameForAssociation}, UNNEST({roles}) AS {ColumnNameForRole})

    INSERT INTO {table} ({ColumnNameForAssociation},{ColumnNameForRole})
    SELECT {ColumnNameForAssociation}, {ColumnNameForRole}
    FROM relations";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForAddRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForAddRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void RemoveCompositeRoleRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;
            var roles = this.CompositeRoleArrayParam;
            var rolesType = roles.TypeName;

            var dropArgs = $"({objectsType}, {rolesType})";
            var funcParams = $"({objects} {objectsType}, {roles} {rolesType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH relations AS (SELECT UNNEST({objects}) AS {ColumnNameForAssociation}, UNNEST({roles}) AS {ColumnNameForRole})

    DELETE FROM {table}
    USING relations
    WHERE {table}.{ColumnNameForAssociation}=relations.{ColumnNameForAssociation} AND {table}.{ColumnNameForRole}=relations.{ColumnNameForRole}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForRemoveRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForRemoveRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositeRoleRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForAssociation} {SqlTypeForObject})";
            var funcReturns = $"RETURNS {SqlTypeForObject}";
            var funcBody = $@"DECLARE {this.ParamNameForCompositeRole} {SqlTypeForObject};
BEGIN
    SELECT {ColumnNameForRole}
    FROM {table}
    WHERE {ColumnNameForAssociation}={this.ParamNameForAssociation}
    INTO {this.ParamNameForCompositeRole};

    RETURN {this.ParamNameForCompositeRole};
END";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetRoleByRelationType.Add(relationType, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE plpgsql
AS $$
{funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositeRoleRelationType(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {ColumnNameForRole} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForAssociation}, {ColumnNameForRole}
    FROM {table}
    WHERE {ColumnNameForAssociation} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForPrefetchRoleByRelationType.Add(relationType, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void SetCompositeRoleRelationType(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;
            var roles = this.CompositeRoleArrayParam;
            var rolesType = roles.TypeName;

            var dropArgs = $"({objectsType}, {rolesType})";
            var funcParams = $"({objects} {objectsType}, {roles} {rolesType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH relations AS (SELECT UNNEST({objects}) AS {ColumnNameForAssociation}, UNNEST({roles}) AS {ColumnNameForRole})

    INSERT INTO {table}
    SELECT {ColumnNameForAssociation}, {ColumnNameForRole} from relations

    ON CONFLICT ({ColumnNameForAssociation})
    DO UPDATE
        SET {ColumnNameForRole} = excluded.{ColumnNameForRole};";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForSetRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForSetRoleByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositeAssociationRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForCompositeRole} {SqlTypeForObject})";
            var funcReturns = $"RETURNS {SqlTypeForObject}";
            var funcBody = $@"DECLARE {this.ParamNameForAssociation} {SqlTypeForObject};
BEGIN
    SELECT {ColumnNameForAssociation}
    FROM {table}
    WHERE {ColumnNameForRole}={this.ParamNameForCompositeRole}
    INTO {this.ParamNameForAssociation};

    RETURN {this.ParamNameForAssociation};
END";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetAssociation + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForGetAssociationByRelationType.Add(relationType, name);

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE plpgsql
AS $$
{funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositeAssociationRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForAssociation} {SqlTypeForObject},
         {ColumnNameForObject} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForAssociation},{ColumnNameForRole}
    FROM {table}
    WHERE {ColumnNameForRole} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchAssociation + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForPrefetchAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetCompositesAssociationRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];

            var dropArgs = $"({SqlTypeForObject})";
            var funcParams = $"({this.ParamNameForCompositeRole} {SqlTypeForObject})";
            var funcReturns = $"RETURNS SETOF {SqlTypeForObject}";
            var funcBody = $@"SELECT {ColumnNameForAssociation}
    FROM {table}
    WHERE {ColumnNameForRole}={this.ParamNameForCompositeRole}";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetAssociation + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);
            this.procedureNameForGetAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void PrefetchCompositesAssociationRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {ColumnNameForAssociation} {SqlTypeForObject}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForAssociation},{ColumnNameForRole}
    FROM {table}
    WHERE {ColumnNameForRole} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForPrefetchAssociation + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForPrefetchAssociationByRelationType.Add(relationType, name);

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE SQL
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void ClearCompositeRoleRelationTable(IRelationType relationType)
        {
            var table = this.tableNameForRelationByRelationType[relationType];
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    DELETE FROM {table}
    WHERE {ColumnNameForAssociation} IN (SELECT {ColumnNameForObject} FROM objects)";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForClearRole + relationType.Id.ToString("N") + dropArgs + funcParams + funcReturns + funcBody);

            this.procedureNameForClearRoleByRelationType.Add(relationType, name);

            var definition =
                $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void UpdateVersionIds()
        {
            var dropArgs = $"({this.ObjectArrayParam.TypeName})";
            var funcParams = $"({this.ObjectArrayParam} {this.ObjectArrayParam.TypeName})";
            var funcReturns = "RETURNS void";
            var funcBody = $@"UPDATE {this.TableNameForObjects}
    SET {ColumnNameForVersion} = {ColumnNameForVersion} + 1
    WHERE {ColumnNameForObject} IN (SELECT {ColumnNameForObject} FROM unnest({this.ObjectArrayParam}) as t({ColumnNameForObject}));";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForUpdateVersion + dropArgs + funcParams + funcReturns + funcBody);
            this.ProcedureNameForUpdateVersion = name;

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void GetVersionIds()
        {
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {ColumnNameForVersion} {SqlTypeForVersion}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {this.TableNameForObjects}.{ColumnNameForObject}, {this.TableNameForObjects}.{ColumnNameForVersion}
    FROM {this.TableNameForObjects}
    WHERE {this.TableNameForObjects}.{ColumnNameForObject} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForGetVersion + dropArgs + funcParams + funcReturns + funcBody);
            this.ProcedureNameForGetVersion = name;

            var definition =
$@"DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";
            this.ProcedureDefinitionByName.Add(name, definition);
        }

        private void Instantiate()
        {
            var objects = this.ObjectArrayParam;
            var objectsType = objects.TypeName;

            var dropArgs = $"({objectsType})";
            var funcParams = $"({objects} {objectsType})";
            var funcReturns = $@"RETURNS TABLE
    (
         {ColumnNameForObject} {SqlTypeForObject},
         {ColumnNameForClass} {SqlTypeForClass},
         {ColumnNameForVersion} {SqlTypeForVersion}
    )";
            var funcBody = $@"WITH objects AS (SELECT UNNEST({objects}) AS {ColumnNameForObject})

    SELECT {ColumnNameForObject}, {ColumnNameForClass}, {ColumnNameForVersion}
    FROM {this.TableNameForObjects}
    WHERE {this.TableNameForObjects}.{ColumnNameForObject} IN (SELECT {ColumnNameForObject} FROM objects);";

            var name = this.Database.SchemaName + "." + HashIdentifier(
                ProcedurePrefixForInstantiate + dropArgs + funcParams + funcReturns + funcBody);
            this.ProcedureNameForInstantiate = name;

            var definition = $@"
DROP FUNCTION IF EXISTS {name}{dropArgs};
CREATE FUNCTION {name}{funcParams}
    {funcReturns}
    LANGUAGE sql
AS $$
    {funcBody}
$$;";

            this.ProcedureDefinitionByName.Add(name, definition);
        }

    }
}
