using DAO;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_Bill
    {
        private static BUS_Bill instance;

        public static BUS_Bill Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_Bill();
                return instance;
            }
        }
        public void UpdateBill(int idTableTo, int idBill)
        {
            DAO_Bill.Instance.UpdateBill(idTableTo, idBill);
        }
        public Bill getBillByIdTable(int id)
        {
            return DAO_Bill.Instance.getBillByIdTable(id);
        }
        public void InsertBill(int id)
        {
            DAO_Bill.Instance.InsertBill(id);
        }
        public void CheckOutBill(int id, float total)
        {
            DAO_Bill.Instance.CheckOutBill(id, total);
        }
        public List<Bill> getBillByDate(DateTime fromdate, DateTime todate)
        {
            return DAO_Bill.Instance.getBillByDate(fromdate, todate);
        }
        public List<Bill> SearchBillByDate(DateTime fromdate, DateTime todate, int name)
        {
            return DAO_Bill.Instance.SearchBillByDate(fromdate, todate, name);
        }
    }
}
