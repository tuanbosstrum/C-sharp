﻿
namespace GUI
{
    partial class RPBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RView
            // 
            this.RView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RView.Location = new System.Drawing.Point(0, 0);
            this.RView.Name = "RView";
            this.RView.ServerReport.BearerToken = null;
            this.RView.Size = new System.Drawing.Size(313, 450);
            this.RView.TabIndex = 0;
            // 
            // RPBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.RView);
            this.Name = "RPBill";
            this.Text = "Thanh toán hóa đơn";
            this.Load += new System.EventHandler(this.RPBill_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer RView;
    }
}