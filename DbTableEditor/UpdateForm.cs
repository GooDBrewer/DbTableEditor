using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DbTableEditor
{
    public partial class UpdateForm : Form
    {

        private readonly ITableService _tableService;
        private string _tableName;
        private string _primaryKey;

        public UpdateForm(ITableService tableService)
        {
            InitializeComponent();
            _tableService = tableService;
            lableTab.Text = "Таблица: " + _tableName;
        }
        public void InitializeTableName(string tableName)
        {
            _tableName = tableName;
        }

        private void renameTable_Click(object sender, EventArgs e)
        {
            var newTableName = Interaction.InputBox("Введите новое название таблицы: ",
                "Изменение названия",
                "");

            if (!string.IsNullOrWhiteSpace(newTableName))
            {
                try
                {
                    MessageBox.Show($"Вы ввели: {newTableName}");
                    _tableService.RenameTable(_tableName, newTableName);
                    _tableName = newTableName;
                    lableTab.Text = "Таблица: " + newTableName;
                }
                catch { MessageBox.Show("Ошибка при изменении названия таблицы!"); }
            }


        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _tableService.ReadTable(_tableName);
            lableTab.Text = "Таблица: " + _tableName;
            comBoxType.Items.AddRange(new string[]{    "INT",
                                                            "SERIAL",
                                                            "VARCHAR(50)",
                                                            "VARCHAR(100)",
                                                            "TEXT",
                                                            "DATE",
                                                            "TIMESTAMP",
                                                            "BOOLEAN",
                                                            "NUMERIC"
                                                       });
            comBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void renameColumn_Click(object sender, EventArgs e)
        {

            try
            {

                var cell = dataGridView1.SelectedCells[0];
                int colIndex = cell.ColumnIndex;

                string oldColumnName = dataGridView1.Columns[colIndex].HeaderText;
                var newColumnName = Interaction.InputBox("Введите новое название поля: ",
                "Изменение названия",
                "");

                if (!string.IsNullOrWhiteSpace(newColumnName))
                {
                    try
                    {
                        MessageBox.Show($"Вы ввели: |{newColumnName}| меняем |{oldColumnName}|");
                        _tableService.RenameColumn(_tableName, oldColumnName, newColumnName);
                    }
                    catch { MessageBox.Show("Ошибка при изменении названия таблицы!"); }
                }
                dataGridView1.DataSource = _tableService.ReadTable(_tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в изменении имени поля " + ex);
            }
        }

        private void chngType_Click(object sender, EventArgs e)
        {
            try
            {
                var cell = dataGridView1.SelectedCells[0];
                int colIndex = cell.ColumnIndex;

                var colName = dataGridView1.Columns[colIndex].HeaderText;
                var newType = comBoxType.Text.Trim();

                _tableService.ChangeColumnType(_tableName, colName, newType);
                MessageBox.Show("Смена типа данных успешна!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в изменении типа данных поля:" + ex);
            }
        }

        private void dltColumn_Click(object sender, EventArgs e)
        {

        }

        private void AddColumn_Click(object sender, EventArgs e)
        {

        }
    }
}
