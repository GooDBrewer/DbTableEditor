namespace DbTableEditor
{
    partial class CreateTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            createTable = new Button();
            label3 = new Label();
            txtPrimaryKey = new TextBox();
            chkNotNull = new CheckBox();
            comboColumnType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtColumnName = new TextBox();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1249, 588);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(createTable);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPrimaryKey);
            panel1.Controls.Add(chkNotNull);
            panel1.Controls.Add(comboColumnType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtColumnName);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(892, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 588);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(118, 318);
            button3.Name = "button3";
            button3.Size = new Size(68, 23);
            button3.TabIndex = 11;
            button3.Text = "создать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // createTable
            // 
            createTable.Location = new Point(13, 536);
            createTable.Name = "createTable";
            createTable.Size = new Size(175, 40);
            createTable.TabIndex = 10;
            createTable.Text = "Создать таблицу";
            createTable.UseVisualStyleBackColor = true;
            createTable.Click += createTable_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 271);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 9;
            label3.Text = "PRIMARY KEY";
            // 
            // txtPrimaryKey
            // 
            txtPrimaryKey.Location = new Point(12, 289);
            txtPrimaryKey.Name = "txtPrimaryKey";
            txtPrimaryKey.Size = new Size(174, 23);
            txtPrimaryKey.TabIndex = 8;
            // 
            // chkNotNull
            // 
            chkNotNull.AutoSize = true;
            chkNotNull.Location = new Point(23, 115);
            chkNotNull.Name = "chkNotNull";
            chkNotNull.Size = new Size(81, 19);
            chkNotNull.TabIndex = 7;
            chkNotNull.Text = "NOT NULL";
            chkNotNull.UseVisualStyleBackColor = true;
            // 
            // comboColumnType
            // 
            comboColumnType.FormattingEnabled = true;
            comboColumnType.Location = new Point(14, 86);
            comboColumnType.Name = "comboColumnType";
            comboColumnType.Size = new Size(175, 23);
            comboColumnType.TabIndex = 6;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 68);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Тип данных поля";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Название поля";
            // 
            // txtColumnName
            // 
            txtColumnName.Location = new Point(14, 29);
            txtColumnName.Name = "txtColumnName";
            txtColumnName.Size = new Size(175, 23);
            txtColumnName.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(13, 458);
            button2.Name = "button2";
            button2.Size = new Size(175, 40);
            button2.TabIndex = 1;
            button2.Text = "Удалить поле";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 140);
            button1.Name = "button1";
            button1.Size = new Size(175, 40);
            button1.TabIndex = 0;
            button1.Text = "Добавить поле";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1092, 588);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "CreateTableForm";
            Text = "Создание таблицы";
            Load += CreateTableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox txtColumnName;
        private Label label2;
        private ComboBox comboColumnType;
        private CheckBox chkNotNull;
        private Label label3;
        private TextBox txtPrimaryKey;
        private Button createTable;
        private Button button3;
    }
}