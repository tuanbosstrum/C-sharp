using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class RPSales : Form
    {
        List<Bill> bills;
        DateTime date_;
        public RPSales(List<Bill> getbills, DateTime date)
        {
            InitializeComponent();
            this.bills = getbills;
            this.date_ = date;
        }

        private void RPSales_Load(object sender, EventArgs e)
        {
            RpView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            RpView.LocalReport.ReportPath = @"UISales.rdlc";
            if (bills != null)
            {
                Microsoft.Reporting.WinForms.ReportParameter[] parameter = new Microsoft.Reporting.WinForms.ReportParameter[]{
                    new Microsoft.Reporting.WinForms.ReportParameter("ToDay",date_.ToString())

                };
                ReportDataSource data = new ReportDataSource();
                data.Name = "DataBill";
                data.Value = bills;
                RpView.LocalReport.DataSources.Clear();
                RpView.LocalReport.DataSources.Add(data);
                this.RpView.LocalReport.SetParameters(parameter);
            }
            this.RpView.RefreshReport();
        }
    }
}
