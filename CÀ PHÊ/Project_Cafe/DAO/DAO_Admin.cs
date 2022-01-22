using System;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_Admin
    {
        private static DAO_Admin instance;
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;

        public static DAO_Admin Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_Admin();
                return instance;
            }
        }
        public DataTable CheckAccount(string username, string password)
        {
            DataTable data = new DataTable();
            string query = "CheckAccount @username , @password";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                da = new SqlDataAdapter(cmd);
                da.Fill(data);
                conn.Close();
            }
            catch (Exception)
            {
            }
            return data;
        }
    }
}
