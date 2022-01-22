using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_Staff
    {
        private static BUS_Staff instance;

        public static BUS_Staff Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Staff();
                }
                return instance;
            }

        }
        public List<Staff> getListStaff()
        {
            return DAO_Staff.Instance.getListStaff();
        }
        public void InsertStaff(string fullname, string phone, string address, string namelevel)
        {
            DAO_Staff.Instance.InsertStaff(fullname, phone, address, namelevel);
        }
        public void UpdateStaff(string fullname, string phone, string address, string namelevel, int id)
        {
            DAO_Staff.Instance.UpdateStaff(fullname, phone, address, namelevel, id);
        }
        public void DeleteStaff(int id)
        {
            DAO_Staff.Instance.DeleteStaff(id);
        }
        public List<Staff> FindStaff(string fullname)
        {
            return DAO_Staff.Instance.FindStaff(fullname);
        }
    }
}
