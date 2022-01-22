using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Food
    {
        private static DAO_Food instance;
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public static DAO_Food Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_Food();
                }
                return instance;
            }

        }
        public void UpdateFood(string name, int idCate, int price, string image, int id)
        {
            string query = "UpdateFood @name , @idCategory , @price, @image ,@id";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@idCategory", SqlDbType.Int).Value = idCate;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                cmd.Parameters.Add("@image", SqlDbType.NVarChar).Value = image;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch { }
        }
        public void InsertFood(string name, int idCate, int price, string image)
        {
            string query = "InsertFood @name , @idCategory , @price, @image";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@idCategory", SqlDbType.Int).Value = idCate;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                cmd.Parameters.Add("@image", SqlDbType.NVarChar).Value = image;
                cmd.ExecuteNonQuery();
            }
            catch { }
        }
        public Foods GetFoods(int id)
        {
            Foods food = new Foods();
            string query = "GetFood @id";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    food.IdFood = (int)dr["id"];
                    food.NameFood = dr["name"].ToString();
                    food.Id_categoryFood = (int)dr["idCategory"];
                    food.PriceFood = (double)dr["price"];
                    food.ImageFood = dr["image"].ToString();
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return food;
        }
        public List<Foods> ListFoodByPrice(int price)
        {
            List<Foods> listFood = new List<Foods>();
            string query = "ListFoodByPrice @price";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Foods food = new Foods();
                    food.IdFood = (int)dr["id"];
                    food.NameFood = dr["name"].ToString();
                    //food.Id_categoryFood = (int)dr["idCategory"];
                    food.PriceFood = (double)dr["price"];
                    food.ImageFood = dr["image"].ToString();
                    listFood.Add(food);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return listFood;
        }
        public List<Foods> ListFoodByCate(string name)
        {
            List<Foods> listFood = new List<Foods>();
            string query = "ListFoodByCate @name";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Foods food = new Foods();
                    food.IdFood = (int)dr["id"];
                    food.NameFood = dr["name"].ToString();
                    //food.Id_categoryFood = (int)dr["idCategory"];
                    food.PriceFood = (double)dr["price"];
                    food.ImageFood = dr["image"].ToString();
                    listFood.Add(food);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return listFood;
        }
        public List<Foods> getListFood()
        {
            List<Foods> listFood = new List<Foods>();
            string query = "ListFood";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Foods food = new Foods();
                    food.IdFood = (int)dr["id"];
                    food.NameFood = dr["name"].ToString();
                    food.Id_categoryFood = (int)dr["idCategory"];
                    food.PriceFood = (double)dr["price"];
                    food.ImageFood = dr["image"].ToString();
                    listFood.Add(food);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return listFood;
        }


    }
}
