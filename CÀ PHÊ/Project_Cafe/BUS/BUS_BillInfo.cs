using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_BillInfo
    {
        private static BUS_BillInfo instance;

        public static BUS_BillInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_BillInfo();
                return instance;
            }
        }
        public List<BillInfo> getBillInfoByIdBill(int id)
        {
            return DAO_BillInfo.Instance.getBillInfoByIdBill(id);
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DAO_BillInfo.Instance.InsertBillInfo(idBill, idFood, count);
        }
        public void UpdateBillInfo(int count, int id)
        {
            DAO_BillInfo.Instance.UpdateBillInfo(count, id);
        }
        public void DelBillInfo(int idBill, int idFood)
        {
            DAO_BillInfo.Instance.DelBillInfo(idBill, idFood);
        }
    }
}
