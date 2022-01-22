using DAO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class FSetting : Form
    {
        public FSetting()
        {
            InitializeComponent();
            txtServerName.Text = System.Environment.MachineName;
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string servername = txtServerName.Text;
            string database = txtDatabase.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            SqlConnection conn = DataProvider.Instance.ConnectDB(servername, database, username, password);
            if (conn != null)
            {
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kết nối không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            string servername = txtServerName.Text;
            string database = txtDatabase.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            XML.Instance.SaveXML(servername, database, username, password);
            if (XML.Instance.SaveXML(servername, database, username, password))
            {
                MessageBox.Show("Cài đặt thành công", "Thông báo", MessageBoxButtons.OK);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Cài đặt không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void FSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
