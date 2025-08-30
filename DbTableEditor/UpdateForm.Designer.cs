namespace DbTableEditor
{
    partial class UpdateForm
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
            panel1 = new Panel();
            comBoxType = new ComboBox();
            AddPK = new Button();
            dltPK = new Button();
            dltColumn = new Button();
            AddColumn = new Button();
            chngType = new Button();
            renameColumn = new Button();
            renameTable = new Button();
            lableTab = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comBoxType);
            panel1.Controls.Add(AddPK);
            panel1.Controls.Add(dltPK);
            panel1.Controls.Add(dltColumn);
            panel1.Controls.Add(AddColumn);
            panel1.Controls.Add(chngType);
            panel1.Controls.Add(renameColumn);
            panel1.Controls.Add(renameTable);
            panel1.Controls.Add(lableTab);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(813, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 598);
            panel1.TabIndex = 0;
            // 
            // comBoxType
            // 
            comBoxType.FormattingEnabled = true;
            comBoxType.Location = new Point(14, 203);
            comBoxType.Name = "comBoxType";
            comBoxType.Size = new Size(166, 23);
            comBoxType.TabIndex = 8;
            // 
            // AddPK
            // 
            AddPK.Location = new Point(14, 517);
            AddPK.Name = "AddPK";
            AddPK.Size = new Size(166, 40);
            AddPK.TabIndex = 7;
            AddPK.Text = "Задать новый внешний ключ";
            AddPK.UseVisualStyleBackColor = true;
            // 
            // dltPK
            // 
            dltPK.Location = new Point(14, 459);
            dltPK.Name = "dltPK";
            dltPK.Size = new Size(166, 40);
            dltPK.TabIndex = 6;
            dltPK.Text = "Удалить внешний ключ";
            dltPK.UseVisualStyleBackColor = true;
            // 
            // dltColumn
            // 
            dltColumn.Location = new Point(14, 376);
            dltColumn.Name = "dltColumn";
            dltColumn.Size = new Size(166, 40);
            dltColumn.TabIndex = 5;
            dltColumn.Text = "Удалить поле";
            dltColumn.UseVisualStyleBackColor = true;
            dltColumn.Click += dltColumn_Click;
            // 
            // AddColumn
            // 
            AddColumn.Location = new Point(14, 318);
            AddColumn.Name = "AddColumn";
            AddColumn.Size = new Size(166, 40);
            AddColumn.TabIndex = 4;
            AddColumn.Text = "Добавить поле";
            AddColumn.UseVisualStyleBackColor = true;
            AddColumn.Click += AddColumn_Click;
            // 
            // chngType
            // 
            chngType.Location = new Point(14, 157);
            chngType.Name = "chngType";
            chngType.Size = new Size(166, 40);
            chngType.TabIndex = 3;
            chngType.Text = "Изменить тип данных поля";
            chngType.UseVisualStyleBackColor = true;
            chngType.Click += chngType_Click;
            // 
            // renameColumn
            // 
            renameColumn.Location = new Point(14, 99);
            renameColumn.Name = "renameColumn";
            renameColumn.Size = new Size(166, 40);
            renameColumn.TabIndex = 2;
            renameColumn.Text = "Переименовать поле";
            renameColumn.UseVisualStyleBackColor = true;
            renameColumn.Click += renameColumn_Click;
            // 
            // renameTable
            // 
            renameTable.Location = new Point(14, 41);
            renameTable.Name = "renameTable";
            renameTable.Size = new Size(166, 40);
            renameTable.TabIndex = 1;
            renameTable.Text = "Переименовать таблицу";
            renameTable.UseVisualStyleBackColor = true;
            renameTable.Click += renameTable_Click;
            // 
            // lableTab
            // 
            lableTab.AutoSize = true;
            lableTab.Location = new Point(14, 9);
            lableTab.Name = "lableTab";
            lableTab.Size = new Size(56, 15);
            lableTab.TabIndex = 0;
            lableTab.Text = "Таблица:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(813, 598);
            dataGridView1.TabIndex = 1;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 598);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UpdateForm";
            Text = "Редактор таблицы";
            Load += UpdateForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label lableTab;
        private Button renameTable;
        private Button AddPK;
        private Button dltPK;
        private Button dltColumn;
        private Button AddColumn;
        private Button chngType;
        private Button renameColumn;
        private ComboBox comBoxType;
    }
}