namespace DbTableEditor
{
    partial class ConnectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtHost;
        private TextBox txtPort;
        private TextBox txtDatabase;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnConnect;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtHost = new TextBox();
            txtPort = new TextBox();
            txtDatabase = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnConnect = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtHost
            // 
            txtHost.Location = new Point(12, 12);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(111, 23);
            txtHost.TabIndex = 0;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(12, 41);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(111, 23);
            txtPort.TabIndex = 1;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(12, 70);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(111, 23);
            txtDatabase.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 99);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(111, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(111, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 157);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(111, 23);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 15);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 6;
            label1.Text = "Host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 44);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 7;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 73);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 8;
            label3.Text = "DataBase Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 102);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 9;
            label4.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 131);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // ConnectionForm
            // 
            ClientSize = new Size(836, 476);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHost);
            Controls.Add(txtPort);
            Controls.Add(txtDatabase);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(btnConnect);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ConnectionForm";
            Text = "Подключение к PostgreSQL";
            Load += ConnectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
