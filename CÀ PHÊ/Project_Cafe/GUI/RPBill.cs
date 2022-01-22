using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class RPBill : Form
    {
        List<ItemBill> bills;
        string total_;
        //Bill bill_;
        public RPBill(List<ItemBill> items,double total)// Bill bill)
        {
            InitializeComponent();
            this.bills = items;
            //this.bill_ = bill;
            this.total_ = total.ToString("C").Replace(",00","");
           

        }

        private void RPBill_Load(object sender, EventArgs e)
        {
            
            RView.LocalReport.ReportPath =Application.StartupPath + @"\UIBill.rdlc";
            if (bills != null)
            {
                ReportDataSource source = new ReportDataSource();
                source.Name = "DSBill";
                source.Value = bills;
                RView.LocalReport.DataSources.Clear();
                RView.LocalReport.DataSources.Add(source);

            }
            Microsoft.Reporting.WinForms.ReportParameter[] parameter = new Microsoft.Reporting.WinForms.ReportParameter[]{
                    new Microsoft.Reporting.WinForms.ReportParameter("pTotal",total_)
                    
                };
            RView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.RView.LocalReport.SetParameters(parameter);
            this.RView.RefreshReport();
        }
    }
}
