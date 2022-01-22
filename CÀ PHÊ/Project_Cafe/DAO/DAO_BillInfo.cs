using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_BillInfo
    {
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        private static DAO_BillInfo instance;

        public static DAO_BillInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_BillInfo();
                return instance;
            }
        }
        public void DelBillInfo(int idBill, int idFood)
        {
            string query = "DelBillInfo @idBill, @idFood";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idBill", SqlDbType.Int).Value = idBill;
                cmd.Parameters.Add("@idFood", SqlDbType.Int).Value = idFood;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void UpdateBillInfo(int count, int id)
        {
            string query = "UpdateBillInfo @count, @id";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@count", SqlDbType.Int).Value = count;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public List<BillInfo> getBillInfoByIdBill(int id)
        {
            List<BillInfo> listinfo = new List<BillInfo>();
            string query = "getBillInfoById @idBill";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idBill", SqlDbType.Int).Value = id;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BillInfo info = new BillInfo();
                    info.Id = (int)dr["id"];
                    info.IdBill = (int)dr["idBill"];
                    info.IdFood = (int)dr["idFood"];
                    info.Count = (int)dr["count"];
                    listinfo.Add(info);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }

            return listinfo;

        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            string query = "InsertBillInfo @idBill,@idFood,@count";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idBill", SqlDbType.Int).Value = idBill;
                cmd.Parameters.Add("@idFood", SqlDbType.Int).Value = idFood;
                cmd.Parameters.Add("@count", SqlDbType.Int).Value = count;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
