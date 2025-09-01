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

    public partial class AddColumnForm : Form
    {
        private readonly ITableService _tableService;
        private string _tableName;
        public AddColumnForm(ITableService tableService)
        {
            InitializeComponent();
            _tableService = tableService;
        }
        public void InitializeTableName(string tableName)
        {
            _tableName = tableName;

        }
        private void AddColumnForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(DatabaseConfig.ColumnTypes);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)//добавляем поле
        {
            var colName = textBox1.Text.Trim();
            var colType = comboBox1.Text.Trim();
            _tableService.AddColumn(_tableName, colName, colType);
            this.Close();
        }

      
    }
}
