using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using DbTableEditor.Models;

namespace DbTableEditor.Repositories
{
    public interface ITableRepository
    {
        void CreateTable(string tableName, string primarykey, List<ColumnDefinition> columns);
        void DropTable(string tableName);
        void RenameTable(string oldTableName, string tableName);
        void RenameColumn(string tableName, string oldColumnName, string columnName);
        void ChangeColumnType(string tableName, string columnName, string columnType);
        void AddColumn(string tableName, string columnName, string columnType);
        void RemoveColumn(string tableName, string columnName);

        List<string> GetAllTables();
        DataTable ReadTable(string tableName);
    }
}
