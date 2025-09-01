using DbTableEditor.Models;
using DbTableEditor.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbTableEditor.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _repository;

        public TableService(ITableRepository repository)
        {
            _repository = repository;
        }

        public void CreateTable(string tableName, string primarykey, List<ColumnDefinition> columns)
        {

            if (string.IsNullOrWhiteSpace(tableName))
            {
                MessageBox.Show("Имя таблицы не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // выходим из метода
            }

            if (string.IsNullOrWhiteSpace(primarykey))
            {
                MessageBox.Show("Первичный ключ не задан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (columns == null || columns.Count == 0)
            {
                MessageBox.Show("Список полей не должен быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _repository.CreateTable(tableName, primarykey, columns);
            }
            catch ( Exception ex)
            {
                MessageBox.Show("не получилось создать таблицу");
            }
        }

        public void DropTable(string tableName)
        {
            if (MessageBox.Show($"Удалить таблицу {tableName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _repository.DropTable(tableName);
                MessageBox.Show($"Таблица {tableName} удалена");
            }
        }

        public DataTable ReadTable(string tableName)=> _repository.ReadTable(tableName);

        public void RenameTable(string oldTableName, string tableName)
        {
            try
            {
                _repository.RenameTable(oldTableName, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка переименования таблицы: " +  ex.Message);
            }
        }

        public void RenameColumn(string tableName, string oldColumnName, string newColumnName)
        {
            try
            {
                _repository.RenameColumn(tableName, oldColumnName, newColumnName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка переименования поля: " + ex.Message);
            }
        }

        public void ChangeColumnType(string tableName, string columnName, string columnType)
        {
            try
            {
                _repository.ChangeColumnType(tableName, columnName, columnType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка изменения типа данных поля: " + ex.Message);
            }
        }
        public void AddColumn(string tableName, string columnName, string columnType)
        {
            try
            {
                _repository.AddColumn(tableName, columnName, columnType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления поля: " + ex.Message);
            }
        }
        public void RemoveColumn(string tableName, string columnName)
        {
            try
            {
                _repository.RemoveColumn(tableName, columnName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления поля поля: " + ex.Message);
            }
        }


        public List<string> GetAllTables()          => _repository.GetAllTables();
       
    }
}
