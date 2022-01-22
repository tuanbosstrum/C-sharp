
namespace GUI
{
    partial class Custom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LHour = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaInfo = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LCalendar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LSeconds = new System.Windows.Forms.Label();
            this.TCalendar = new System.Windows.Forms.Timer(this.components);
            this.Gif = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PGif = new System.Windows.Forms.Panel();
            this.LBTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PGif.SuspendLayout();
            this.SuspendLayout();
            // 
            // LHour
            // 
            this.LHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LHour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LHour.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LHour.Location = new System.Drawing.Point(46, 0);
            this.LHour.Name = "LHour";
            this.LHour.Size = new System.Drawing.Size(260, 107);
            this.LHour.TabIndex = 0;
            this.LHour.Text = "13:11";
            this.LHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.LBTitle);
            this.panel1.Location = new System.Drawing.Point(18, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 41);
            this.panel1.TabIndex = 3;
            // 
            // gunaInfo
            // 
            this.gunaInfo.BorderRadius = 35;
            this.gunaInfo.TargetControl = this.panel1;
            // 
            // LCalendar
            // 
            this.LCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LCalendar.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCalendar.Location = new System.Drawing.Point(75, 147);
            this.LCalendar.Name = "LCalendar";
            this.LCalendar.Size = new System.Drawing.Size(200, 27);
            this.LCalendar.TabIndex = 4;
            this.LCalendar.Text = "THG7 - 21 -2021";
            this.LCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.LSeconds);
            this.panel2.Controls.Add(this.LHour);
            this.panel2.Controls.Add(this.LCalendar);
            this.panel2.Location = new System.Drawing.Point(18, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 179);
            this.panel2.TabIndex = 5;
            // 
            // LSeconds
            // 
            this.LSeconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LSeconds.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSeconds.ForeColor = System.Drawing.Color.Maroon;
            this.LSeconds.Location = new System.Drawing.Point(75, 112);
            this.LSeconds.Name = "LSeconds";
            this.LSeconds.Size = new System.Drawing.Size(200, 27);
            this.LSeconds.TabIndex = 5;
            this.LSeconds.Text = "60";
            this.LSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCalendar
            // 
            this.TCalendar.Interval = 1000;
            this.TCalendar.Tick += new System.EventHandler(this.Custom_Load);
            // 
            // Gif
            // 
            this.Gif.BorderRadius = 35;
            this.Gif.TargetControl = this.PGif;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.gifCafe;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PGif
            // 
            this.PGif.Controls.Add(this.pictureBox1);
            this.PGif.Location = new System.Drawing.Point(18, 276);
            this.PGif.Name = "PGif";
            this.PGif.Size = new System.Drawing.Size(351, 280);
            this.PGif.TabIndex = 6;
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitle.Location = new System.Drawing.Point(111, 11);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(127, 20);
            this.LBTitle.TabIndex = 0;
            this.LBTitle.Text = "Chào ngày mới";
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.PGif);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Custom";
            this.Size = new System.Drawing.Size(386, 600);
            this.Load += new System.EventHandler(this.Custom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PGif.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LHour;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse gunaInfo;
        private System.Windows.Forms.Label LCalendar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LSeconds;
        private System.Windows.Forms.Timer TCalendar;
        private Guna.UI2.WinForms.Guna2Elipse Gif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PGif;
        private System.Windows.Forms.Label LBTitle;
    }
}
