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
using Microsoft.Extensions.DependencyInjection;
using DbTableEditor.Services;

namespace DbTableEditor
{
    public partial class UpdateForm : Form
    {

        private readonly IServiceProvider _provider;
        private readonly ITableService _tableService;
        private string _tableName;
        private string _primaryKey;

        public UpdateForm(ITableService tableService, IServiceProvider provider)
        {
            InitializeComponent();
            _tableService = tableService;
            _provider = provider;
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

                var oldColumnName = GetSelectedColName(dataGridView1);
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
                var colName = GetSelectedColName(dataGridView1);
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
            try
            {
                var colName = GetSelectedColName(dataGridView1);
                _tableService.RemoveColumn(_tableName, colName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }

        private void AddColumn_Click(object sender, EventArgs e)
        {
            try
            {
                var addColForm = _provider.GetRequiredService<AddColumnForm>();
                addColForm.InitializeTableName(_tableName);
                addColForm.ShowDialog();
                if (addColForm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource = _tableService.ReadTable(_tableName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }
        private string GetSelectedColName(DataGridView select)
        {
            var cell = select.SelectedCells[0];
            int colIndex = cell.ColumnIndex;

            return dataGridView1.Columns[colIndex].HeaderText;
        }
    }
}
