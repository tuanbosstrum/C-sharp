using DAO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlConnection conn = null;
            Form form = new Form();
            FLogin login = new FLogin();
            FSetting setting = new FSetting();
            try
            {
                conn = DataProvider.Instance.Connect();
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    form = setting;
                }
                else
                {
                    form = login;
                }
                conn.Close();
                Application.Run(form);
            }
            catch (Exception)
            {

            }
        }
    }
}
