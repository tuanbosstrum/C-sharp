using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_ItemBill
    {
        private static DAO_ItemBill instance;
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public static DAO_ItemBill Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_ItemBill();
                return instance;
            }
        }
        public List<ItemBill> getListItemByTable(int id)
        {
            List<ItemBill> list = new List<ItemBill>();
            string query = "EXEC ItemBill @idTable";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idTable", SqlDbType.BigInt).Value = id;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ItemBill item = new ItemBill();
                    item.Count = (int)dr["SL"];
                    item.FoodName = dr["NameFood"].ToString();
                    item.Price = (double)dr["Price"];
                    list.Add(item);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return list;
        }
    }
}
