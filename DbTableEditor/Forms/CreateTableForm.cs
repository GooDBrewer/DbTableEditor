using DbTableEditor.Models;
using DbTableEditor.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbTableEditor
{
    public partial class CreateTableForm : Form
    {
        private readonly ITableService _tableService;
        private string _tableName;
        private List<ColumnDefinition> _columns;
        private string _primaryKey;

        public CreateTableForm(ITableService tableService)
        {
            InitializeComponent();
            _tableService = tableService;
            
            _columns = new List<ColumnDefinition>();
        }
        public void InitializeTableName(string tableName)
        {
            _tableName = tableName;
            
        }

        private void CreateTableForm_Load(object sender, EventArgs e)
        {
            comboColumnType.Items.AddRange(DatabaseConfig.ColumnTypes);
            comboColumnType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)//добавляем поле
        {
            var col = AddColumn();

            _columns.Add(col);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _columns;
        }

        private void button2_Click(object sender, EventArgs e)//Удаляем поле
        {
            var col = GetSelectedColumn();
            if (col == null)
            {
                MessageBox.Show("Выберите строку для удаления!");
                return;
            }
            RemoveColumn(col);
        }

        private void button3_Click(object sender, EventArgs e)//задаем первичный ключ
        {
            _primaryKey = txtPrimaryKey.Text.Trim() ;
        }
        private void createTable_Click(object sender, EventArgs e)//создаем запрос на создание таблицы и закрываем форму
        {
            if (string.IsNullOrWhiteSpace(_tableName))
            {
                MessageBox.Show("Имя таблицы не задано.");
                return;
            }
            if (_columns.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну колонку.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(_primaryKey) && !_columns.Any(c => c.Name == _primaryKey))
            {
                MessageBox.Show("Первичный ключ должен совпадать с одной из колонок.");
                return;
            }
            try
            {
                _tableService.CreateTable(_tableName, _primaryKey, _columns);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания таблицы: " + ex.Message);
            }
        }




        private void RemoveColumn(ColumnDefinition colToRemove)
        {

            _columns.Remove(colToRemove);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _columns;
        }
        private ColumnDefinition GetSelectedColumn()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return null;
            return dataGridView1.SelectedRows[0].DataBoundItem as ColumnDefinition;

        }



        private ColumnDefinition AddColumn()
        {
            string colName = txtColumnName.Text.Trim();
            string colType = comboColumnType.Text.Trim();
            bool notNull = chkNotNull.Checked;

            if (string.IsNullOrWhiteSpace(colName) || string.IsNullOrWhiteSpace(colType))
            {
                MessageBox.Show("Имя или тип данных не указаны!");
                
            }

            var col = new ColumnDefinition
            {
                Name = colName,
                DataType = colType,
                IsNotNull = notNull,
            };
            return col;
        }
    }
}
