

namespace DbTableEditor
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            tableBox = new ListBox();
            rightPanel = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableBox
            // 
            tableBox.BackColor = SystemColors.InactiveCaption;
            tableBox.Dock = DockStyle.Left;
            tableBox.Location = new Point(0, 0);
            tableBox.Name = "tableBox";
            tableBox.Size = new Size(118, 547);
            tableBox.TabIndex = 0;
            tableBox.DoubleClick += tableBox_DoubleClick;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(button3);
            rightPanel.Controls.Add(button2);
            rightPanel.Controls.Add(button1);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(843, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(161, 547);
            rightPanel.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(6, 139);
            button3.Name = "button3";
            button3.Size = new Size(143, 26);
            button3.TabIndex = 2;
            button3.Text = "Изменить таблицу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 44);
            button2.Name = "button2";
            button2.Size = new Size(143, 26);
            button2.TabIndex = 1;
            button2.Text = "Удалить таблицу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 12);
            button1.Name = "button1";
            button1.Size = new Size(143, 26);
            button1.TabIndex = 0;
            button1.Text = "Создать таблицу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCreateTable_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(118, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 547);
            dataGridView1.TabIndex = 1;
            // 
            // MainForm
            // 
            ClientSize = new Size(1004, 547);
            Controls.Add(dataGridView1);
            Controls.Add(rightPanel);
            Controls.Add(tableBox);
            Name = "MainForm";
            Text = "Редактор таблиц";
            Load += MainForm_Load_1;
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }
        private Panel rightPanel;
        private ListBox tableBox;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}