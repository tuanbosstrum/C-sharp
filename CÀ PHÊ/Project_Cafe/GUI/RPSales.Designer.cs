
namespace GUI
{
    partial class RPSales
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
            this.RpView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RpView
            // 
            this.RpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpView.Location = new System.Drawing.Point(0, 0);
            this.RpView.Name = "RpView";
            this.RpView.Size = new System.Drawing.Size(714, 563);
            this.RpView.TabIndex = 0;
            // 
            // RPSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 563);
            this.Controls.Add(this.RpView);
            this.Name = "RPSales";
            this.Text = "RPSales";
            this.Load += new System.EventHandler(this.RPSales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpView;
    }
}