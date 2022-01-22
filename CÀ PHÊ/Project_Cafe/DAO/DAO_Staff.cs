using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Staff
    {
        private static DAO_Staff instance;
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public static DAO_Staff Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_Staff();
                }
                return instance;
            }

        }
        public List<Staff> getListStaff()
        {
            List<Staff> liststaff = new List<Staff>();
            string query = "ListStaff";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Staff staff = new Staff();
                    staff.Id = (int)dr["id"];
                    staff.Fullname = dr["Fullname"].ToString();
                    staff.Phone = dr["Phone"].ToString();
                    staff.Address = dr["Address"].ToString();
                    staff.Namelevel = dr["NameLevel"].ToString();
                    liststaff.Add(staff);
                }
                conn.Close();

            }
            catch (Exception)
            {

            }

            return liststaff;
        }
        public void InsertStaff(string fullname, string phone, string address, string namelevel)
        {
            string query = "InsertStaff @fullname , @phone , @address, @namelevel";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = fullname;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.Add("@namelevel", SqlDbType.NVarChar).Value = namelevel;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
        }
        public void UpdateStaff(string fullname, string phone, string address, string namelevel, int id)
        {
            string query = "UpdateStaff  @id ,@fullname , @phone , @address, @namelevel";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = fullname;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.Add("@namelevel", SqlDbType.NVarChar).Value = namelevel;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
        }
        public void DeleteStaff(int id)
        {
            string query = "DeleteStaff @id";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }


        }
        public List<Staff> FindStaff(string fullname)
        {
            List<Staff> liststaff = new List<Staff>();
            string query = "FindStaff @fullname";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = fullname;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Staff staff = new Staff();
                    staff.Id = (int)dr["id"];

                    staff.Fullname = dr["Fullname"].ToString();
                    staff.Phone = dr["Phone"].ToString();
                    staff.Address = dr["Address"].ToString();
                    staff.Namelevel = dr["NameLevel"].ToString();
                    liststaff.Add(staff);
                }
                conn.Close();

            }
            catch (Exception)
            {

            }

            return liststaff;
        }

    }

}
