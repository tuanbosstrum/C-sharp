using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Bill
    {
        private static DAO_Bill instance;
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public static DAO_Bill Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_Bill();
                return instance;
            }
        }
        public List<Bill> SearchBillByDate(DateTime fromdate, DateTime todate, int name)
        {
            List<Bill> bills = new List<Bill>();
            string query = "SearchBillByDate @fromDate , @toDate , @name";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@fromDate", SqlDbType.VarChar).Value = fromdate.ToString("yyyy-MM-dd") + " 00:00:00";
                cmd.Parameters.Add("@toDate", SqlDbType.VarChar).Value = todate.ToString("yyyy-MM-dd") + " 23:59:00";
                cmd.Parameters.Add("@name", SqlDbType.Int).Value = name;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Bill bill = new Bill();
                    bill.Id = (int)dr["id"];
                    bill.DateCheckIn = (DateTime)dr["DateCheckIn"];
                    bill.DateCheckOut = (DateTime)dr["DateCheckOut"];
                    bill.Nametable = dr["name"].ToString();
                    bill.Total = (double)dr["total"];
                    bills.Add(bill);
                }

            }
            catch (Exception)
            {
            }
            return bills;
        }
        public List<Bill> getBillByDate(DateTime fromdate, DateTime todate)
        {
            List<Bill> bills = new List<Bill>();
            string query = "ListBillByDate @fromDate , @toDate";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@fromDate", SqlDbType.VarChar).Value = fromdate.ToString("yyyy-MM-dd") + " 00:00:00";
                cmd.Parameters.Add("@toDate", SqlDbType.VarChar).Value = todate.ToString("yyyy-MM-dd") + " 23:59:00";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Bill bill = new Bill();
                    bill.Id = (int)dr["id"];
                    bill.DateCheckIn = (DateTime)dr["DateCheckIn"];
                    bill.DateCheckOut = (DateTime)dr["DateCheckOut"];
                    bill.Nametable = dr["name"].ToString();
                    bill.Total = (double)dr["total"];
                    bills.Add(bill);
                }

            }
            catch (Exception)
            {
            }
            return bills;
        }
        public void CheckOutBill(int id, float total)
        {
            string query = "Checkout @idBill, @total";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idBill", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@total", SqlDbType.Float).Value = total;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void UpdateBill(int idTableTo, int idBill)
        {
            string query = "UpdateBill @idTableTo, @idBill";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idTableTo", SqlDbType.Int).Value = idTableTo;
                cmd.Parameters.Add("@idBill", SqlDbType.Int).Value = idBill;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void InsertBill(int id)
        {
            string query = "InsertBill @idTable";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idTable", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public Bill getBillByIdTable(int id)
        {
            Bill bill = new Bill();
            string query = "getBillByIdTable @idTable";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idTable", SqlDbType.Int).Value = id;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    bill.Id = (int)dr["id"];
                    bill.DateCheckIn = (DateTime)dr["DateCheckIn"];
                    bill.IdTable = (int)dr["idTable"];
                    bill.Status = (int)dr["status"];
                    bill.DateCheckOut = (DateTime)dr["DateCheckOut"];
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return bill;
        }
    }
}
