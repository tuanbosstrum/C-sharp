using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_Category
    {
        private static BUS_Category instance;

        public static BUS_Category Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_Category();
                return instance;
            }
        }
        public List<Category> GetCategories()
        {
            return DAO_Category.Instance.GetCategories();
        }
    }
}
