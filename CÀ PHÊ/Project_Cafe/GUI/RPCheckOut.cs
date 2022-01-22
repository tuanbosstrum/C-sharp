using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RPCheckOut : Form
    {
        List<ItemBill> bills;
        string total_;
        Bill bill_;
        public RPCheckOut(List<ItemBill> items, double total, Bill bill)
        {
            InitializeComponent();
            this.bills = items;
            this.bill_ = bill;
            this.total_ = total.ToString("C").Replace(",00", "");
        }

        private void RPCheckOut_Load(object sender, EventArgs e)
        {
            RView.LocalReport.ReportPath = Application.StartupPath + @"\UICheckOut.rdlc";
            if (bills != null)
            {
                ReportDataSource source = new ReportDataSource();
                source.Name = "DSBill";
                source.Value = bills;
                RView.LocalReport.DataSources.Clear();
                RView.LocalReport.DataSources.Add(source);

            }
            Microsoft.Reporting.WinForms.ReportParameter[] parameter = new Microsoft.Reporting.WinForms.ReportParameter[]{
                    new Microsoft.Reporting.WinForms.ReportParameter("pTotal",total_),
                    new Microsoft.Reporting.WinForms.ReportParameter("TableName",bill_.IdTable.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("FromDate",bill_.DateCheckIn.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("ToDate",bill_.DateCheckOut.ToString())
                };
            RView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.RView.LocalReport.SetParameters(parameter);
            this.RView.RefreshReport();
            
            this.RView.RefreshReport();
        }
    }
}
