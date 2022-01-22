using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Category
    {
        private static DAO_Category instance;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public static DAO_Category Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_Category();
                return instance;
            }

        }
        public List<Category> GetCategories()
        {
            List<Category> List = new List<Category>();
            string query = "GetListCate";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Category category = new Category();
                    category.Id = (int)dr["id"];
                    category.Name = dr["name"].ToString();
                    List.Add(category);
                }
            }
            catch { }
            return List;
        }
    }
}
