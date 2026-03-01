// <copyright file="Reset.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Commands
{
    using System;
    using System.Text.RegularExpressions;
    using Microsoft.Data.SqlClient;
    using Npgsql;

    public static class Reset
    {
        public static int Execute(IProgramContext context)
        {
            var adapter = context.Configuration["Adapter"]?.ToLowerInvariant();
            var connectionString = context.Configuration["ConnectionStrings:DefaultConnection"];

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                Console.Error.WriteLine("Error: ConnectionStrings:DefaultConnection not configured");
                return ExitCode.Error;
            }

            return adapter switch
            {
                "npgsql" => ResetNpgsql(connectionString),
                "sqlclient" => ResetSqlClient(connectionString),
                _ => throw new ArgumentException($"Unknown database adapter: '{adapter}'. Supported adapters: npgsql, sqlclient")
            };
        }

        private static int ResetSqlClient(string connectionString)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            var database = builder.InitialCatalog;

            if (!IsValidDatabaseName(database))
            {
                Console.Error.WriteLine($"Error: Invalid database name: {database}");
                return ExitCode.Error;
            }

            builder.InitialCatalog = "master";
            var masterConnectionString = builder.ConnectionString;

            using var connection = new SqlConnection(masterConnectionString);
            connection.Open();

            // Drop database if exists
            using (var command = new SqlCommand($"DROP DATABASE IF EXISTS [{database}]", connection))
            {
                command.CommandTimeout = 5 * 60;
                command.ExecuteNonQuery();
            }

            // Create database
            using (var command = new SqlCommand($"CREATE DATABASE [{database}]", connection))
            {
                command.CommandTimeout = 5 * 60;
                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Database [{database}] reset successfully (SQL Server)");
            return ExitCode.Success;
        }

        private static int ResetNpgsql(string connectionString)
        {
            var builder = new NpgsqlConnectionStringBuilder(connectionString);
            var database = builder.Database;

            if (!IsValidDatabaseName(database))
            {
                Console.Error.WriteLine($"Error: Invalid database name: {database}");
                return ExitCode.Error;
            }

            builder.Database = "postgres";
            var postgresConnectionString = builder.ConnectionString;

            using var connection = new NpgsqlConnection(postgresConnectionString);
            connection.Open();

            // Terminate existing connections
            using (var command = new NpgsqlCommand(@"
                SELECT pg_terminate_backend(pg_stat_activity.pid)
                FROM pg_stat_activity
                WHERE pg_stat_activity.datname = @database
                AND pid <> pg_backend_pid()", connection))
            {
                command.Parameters.AddWithValue("@database", database);
                command.CommandTimeout = 5 * 60;
                command.ExecuteNonQuery();
            }

            // Drop database if exists
            using (var command = new NpgsqlCommand($"DROP DATABASE IF EXISTS \"{database}\"", connection))
            {
                command.CommandTimeout = 5 * 60;
                command.ExecuteNonQuery();
            }

            // Create database
            using (var command = new NpgsqlCommand($"CREATE DATABASE \"{database}\"", connection))
            {
                command.CommandTimeout = 5 * 60;
                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Database [{database}] reset successfully (PostgreSQL)");
            return ExitCode.Success;
        }

        private static bool IsValidDatabaseName(string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            // Security: only allow letters, numbers, underscores; must start with letter or underscore
            return Regex.IsMatch(name, @"^[a-zA-Z_][a-zA-Z0-9_]*$");
        }
    }
}
