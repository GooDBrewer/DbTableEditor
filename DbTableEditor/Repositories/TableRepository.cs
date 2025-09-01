using DbTableEditor;
using DbTableEditor.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace DbTableEditor.Repositories
{
    public class TableRepository : ITableRepository
    {
        private readonly string _connectionString;

        public TableRepository(DatabaseConfig databaseConfig)
        {
            _connectionString = databaseConfig.ConnectionString;
        }

        public void CreateTable(string tableName, string primarykey, List<ColumnDefinition> columns)
        {

            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            var sb = new StringBuilder();
            foreach (var column in columns)
            {
                sb.Append($"\"{column.Name}\" {column.DataType}");
                if (column.Name == primarykey) sb.Append(" PRIMARY KEY");
                if (column.IsNotNull) sb.Append(" NOT NULL");
                sb.Append(", ");
            }
            sb.Length -= 2;

            string sql = $@"CREATE TABLE IF NOT EXISTS ""{tableName}"" ({sb});";
            
            using var cmd = new NpgsqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка данных: " + ex.Message); }
        }

        public void DropTable(string tableName)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            string sql = $"DROP TABLE IF EXISTS \"{tableName}\" CASCADE";
            using var cmd = new NpgsqlCommand( sql, conn);
            cmd.ExecuteNonQuery();
        }

        public DataTable ReadTable(string tableName)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();


            // Проверим, есть ли таблица в public схеме
            string checkSql = @"
                                    SELECT table_name 
                                    FROM information_schema.tables 
                                    WHERE table_schema = 'public' AND table_name = @tableName;";

            using (var checkCmd = new NpgsqlCommand(checkSql, conn))
            {
                
                checkCmd.Parameters.AddWithValue("tableName", tableName.ToLower());

                var result = checkCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show($"Таблицы '{tableName}' не существует в схеме public.");
                    return new DataTable(); // прекращаем выполнение
                }

                tableName = "\"" + tableName.Replace("\"", "\"\"") + "\"";
                string sql = $"SELECT * FROM {tableName}";
                using var cmd = new NpgsqlCommand(sql, conn);
                using var adapter = new NpgsqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;

            }
        }
        public void RenameTable(string oldTableName,string tableName)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            string sql = $"ALTER TABLE {oldTableName} RENAME TO {tableName};";
            using var cmd = new NpgsqlCommand(sql , conn);
            cmd.ExecuteNonQuery();
        }

        public void RenameColumn(string tableName, string oldColumnName,string newColumnName)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            string sql = $"ALTER TABLE {tableName} RENAME COLUMN {oldColumnName} TO {newColumnName};";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void ChangeColumnType(string tableName, string columnName, string columnType)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            string sql = $"ALTER TABLE {tableName} ALTER COLUMN {columnName} TYPE {columnType} USING {columnName}::{columnType};";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void AddColumn(string tableName, string columnName, string columnType)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            string sql = $"ALTER TABLE {tableName} ADD COLUMN {columnName} {columnType};";
            using var cmd = new NpgsqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
        }
        public void RemoveColumn(string tableName, string columnName)
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            string sql = $"ALTER TABLE {tableName} DROP COLUMN {columnName};";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        
        public List<string> GetAllTables()
        {
            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();

            var tables = new List<string>();
            string sql = @"SELECT table_name
                           FROM information_schema.tables 
                           WHERE table_schema='public' AND table_type='BASE TABLE';";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tables.Add(reader.GetString(0));
            }
            return tables;
        }
    }
}
