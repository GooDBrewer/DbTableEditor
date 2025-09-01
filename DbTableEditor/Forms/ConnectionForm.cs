using Npgsql;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DbTableEditor
{
    public partial class ConnectionForm : Form
    {
        public string ConnectionString { get; private set; }
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //������� ����������� � �� �� ����� Conform
                string host = txtHost.Text;
                string port = txtPort.Text;
                string dbName = txtDatabase.Text;
                string user = txtUser.Text;
                string password = txtPassword.Text;

                ConnectionString = $"Host={host};Port={port};Database={dbName};Username={user};Password={password}";
                using var conn = new NpgsqlConnection(ConnectionString);
                conn.Open();

                MessageBox.Show("����������� �������!", "�����", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("������ �����������: " + ex.Message);
            }
                

        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
