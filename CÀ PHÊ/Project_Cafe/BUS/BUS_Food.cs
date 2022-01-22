using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_Food
    {
        private static BUS_Food instance;

        public static BUS_Food Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Food();
                }
                return instance;
            }
            set => instance = value;
        }
        public void UpdateFood(string name, int idCate, int price, string image, int id)
        {
            DAO_Food.Instance.UpdateFood(name, idCate, price, image, id);
        }
        public void InsertFood(string name, int idCate, int price, string image)
        {
            DAO_Food.Instance.InsertFood(name, idCate, price, image);
        }
        public Foods GetFoods(int id)
        {
            return DAO_Food.Instance.GetFoods(id);
        }
        public List<Foods> getListFood()
        {
            return DAO_Food.Instance.getListFood();
        }
        public List<Foods> ListFoodByCate(string name)
        {
            return DAO_Food.Instance.ListFoodByCate(name);
        }
        public List<Foods> ListFoodByPrice(int price)
        {
            return DAO_Food.Instance.ListFoodByPrice(price);
        }
    }
}
