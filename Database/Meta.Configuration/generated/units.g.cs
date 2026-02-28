namespace Allors.Database.Meta.Configuration
{
    public class Binary : Unit, Meta.Binary {
        public Binary(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.Binary)
        {
        }
    }
    public class Boolean : Unit, Meta.Boolean {
        public Boolean(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.Boolean)
        {
        }
    }
    public class DateTime : Unit, Meta.DateTime {
        public DateTime(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.DateTime)
        {
        }
    }
    public class Decimal : Unit, Meta.Decimal {
        public Decimal(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.Decimal)
        {
        }
    }
    public class Float : Unit, Meta.Float {
        public Float(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.Float)
        {
        }
    }
    public class Integer : Unit, Meta.Integer {
        public Integer(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.Integer)
        {
        }
    }
    public class String : Unit, Meta.String {
        public String(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.String)
        {
        }
    }
    public class Unique : Unit, Meta.Unique {
        public Unique(MetaPopulation metaPopulation, System.Guid id) : base(metaPopulation, id, UnitTags.Unique)
        {
        }
    }
}