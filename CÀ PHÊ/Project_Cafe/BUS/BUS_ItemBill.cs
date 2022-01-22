using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_ItemBill
    {
        private static BUS_ItemBill instance;

        public static BUS_ItemBill Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_ItemBill();
                return instance;
            }

        }
        public List<ItemBill> getListItemByTable(int id)
        {
            return DAO_ItemBill.Instance.getListItemByTable(id);
        }
    }
}
