using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_TableFood
    {
        private static BUS_TableFood instance;

        public static BUS_TableFood Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_TableFood();
                return instance;
            }

        }
        public void UpdateTable(int idTable, string name)
        {
            DAO_TableFood.Instance.UpdateTable(idTable, name);
        }
        public void InsertTable(string name)
        {
            DAO_TableFood.Instance.InsertTable(name);
        }
        public List<TableFood> getTableFood()
        {
            return DAO_TableFood.Instance.getTableFood();
        }
        public void UpdateStatusTable(int id, string status)
        {
            DAO_TableFood.Instance.UpdateStatusTable(id, status);
        }
        public void MoveTable(int idTable, string status, int idTableTo, int idBill, string statusTo, int idTableToCurrent)
        {
            DAO_TableFood.Instance.MoveTable(idTable, status, idTableTo, idBill, statusTo, idTableToCurrent);
        }
    }
}
