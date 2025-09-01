using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;
using Microsoft.Extensions.DependencyInjection;
using DbTableEditor.Services;



namespace DbTableEditor
{
    public partial class MainForm : Form
    {
        private readonly ITableService _tableService;
        private readonly IServiceProvider _provider;
        public MainForm(ITableService tableService, IServiceProvider provider)
        {
            InitializeComponent();
            _tableService = tableService;
            _provider = provider;

        }
        public void RefreshTableList()
        {
            var tables = _tableService.GetAllTables();
            tableBox.DataSource = null;
            tableBox.DataSource = tables;

        }
        private void tableBox_DoubleClick(object sender, EventArgs e)//вывод содержимого таблицы в Grid
        {
            var selectedTableName = tableBox.SelectedItem.ToString();
            dataGridView1.DataSource = _tableService.ReadTable(selectedTableName);
        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            RefreshTableList();
        }

        private void buttonCreateTable_Click(object sender, EventArgs e)//кнопка Создать таблицу
        {
            string tableName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите имя новой таблицы:",
                "Создание таблицы", "");


            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Имя таблицы не может быть пустым");
                return;
            }


            var createForm = _provider.GetRequiredService<CreateTableForm>();
            createForm.InitializeTableName(tableName);
            createForm.ShowDialog();
            RefreshTableList();
        }

        private void button2_Click(object sender, EventArgs e) //удаление таблицы
        {
            string tableName = tableBox.SelectedItem.ToString();
            _tableService.DropTable(tableName);
            RefreshTableList();
        }

        private void button3_Click(object sender, EventArgs e) // изменить таблицу
        {
            var tableName = tableBox.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(tableName))
            {
                MessageBox.Show("Имя таблицы пустое!");
                return;
            }

            MessageBox.Show("Передаю в UpdateForm: " + tableName);

            var updateForm = _provider.GetRequiredService<UpdateForm>();
            updateForm.InitializeTableName(tableName);
            updateForm.ShowDialog();

        }

    }
}
