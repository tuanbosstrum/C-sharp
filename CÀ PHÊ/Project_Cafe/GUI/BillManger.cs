using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class BillManger : UserControl
    {
        public BillManger()
        {

            InitializeComponent();
            DateTime date = DateTime.Now;
            FromDate.Value = new DateTime(date.Year, date.Month, 1);
            ToDate.Value = FromDate.Value.AddMonths(1).AddDays(-1);
            LoadBillByDate(FromDate.Value, ToDate.Value);
        }
        public void LoadBillByDate(DateTime fromdate, DateTime todate)
        {
            dataView.Rows.Clear();
            List<Bill> bills = BUS_Bill.Instance.getBillByDate(fromdate, todate);
            int no = 1;
            double total = 0;
            foreach (Bill bill in bills)
            {
                dataView.Rows.Add(new object[] {
                no++,
                "Bàn " + bill.Nametable,
                bill.DateCheckIn,
                bill.DateCheckOut,
                bill.Total.ToString("C").Replace(",00", "")
                });
                total += bill.Total;
            }
            lbTotal.Text = "Tổng doanh thu: " + total.ToString("C").Replace(",00", "");
            lbCount.Text = "Tổng số hóa đơn: " + (no - 1);

        }
        public void SearchBillByDate(DateTime fromdate, DateTime todate, int name)
        {
            dataView.Rows.Clear();
            List<Bill> bills = BUS_Bill.Instance.SearchBillByDate(fromdate, todate, name);
            int no = 1;
            double total = 0;
            foreach (Bill bill in bills)
            {
                dataView.Rows.Add(new object[] {
                no++,
                "Bàn " + bill.Nametable,
                bill.DateCheckIn,
                bill.DateCheckOut,
                bill.Total.ToString("C").Replace(",00", "")
                });
                total += bill.Total;
            }
            lbTotal.Text = "Tổng doanh thu: " + total.ToString("C").Replace(",00", "");
            lbCount.Text = "Tổng số hóa đơn: " + (no - 1);

        }
        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadBillByDate(FromDate.Value, ToDate.Value);
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            LoadBillByDate(FromDate.Value, ToDate.Value);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int name = int.Parse(txtSearch.Text);
                SearchBillByDate(FromDate.Value, ToDate.Value, name);
            }
            catch (Exception)
            {
                LoadBillByDate(FromDate.Value, ToDate.Value);
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime date = FromDate.Value;
            List<Bill> bills = BUS_Bill.Instance.getBillByDate(FromDate.Value, ToDate.Value);
            RPSales sales = new RPSales(bills, date);
            sales.ShowDialog();
        }
    }
}
