
namespace GUI
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.eElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PLeft = new System.Windows.Forms.Panel();
            this.PHeader = new System.Windows.Forms.Panel();
            this.ControlBox_Min = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBox_Max = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBox_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragMain = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PMain = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnListUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnListSanPham = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDoanhThu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PLeft.SuspendLayout();
            this.PHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eElipse
            // 
            this.eElipse.TargetControl = this;
            // 
            // PLeft
            // 
            this.PLeft.Controls.Add(this.pictureBox1);
            this.PLeft.Controls.Add(this.btnListUser);
            this.PLeft.Controls.Add(this.btnListSanPham);
            this.PLeft.Controls.Add(this.btnDoanhThu);
            this.PLeft.Controls.Add(this.btnHome);
            this.PLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLeft.Location = new System.Drawing.Point(0, 0);
            this.PLeft.Name = "PLeft";
            this.PLeft.Size = new System.Drawing.Size(94, 650);
            this.PLeft.TabIndex = 0;
            // 
            // PHeader
            // 
            this.PHeader.Controls.Add(this.ControlBox_Min);
            this.PHeader.Controls.Add(this.ControlBox_Max);
            this.PHeader.Controls.Add(this.ControlBox_Close);
            this.PHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PHeader.Location = new System.Drawing.Point(94, 0);
            this.PHeader.Name = "PHeader";
            this.PHeader.Size = new System.Drawing.Size(888, 38);
            this.PHeader.TabIndex = 1;
            // 
            // ControlBox_Min
            // 
            this.ControlBox_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox_Min.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlBox_Min.FillColor = System.Drawing.SystemColors.ControlLight;
            this.ControlBox_Min.HoverState.Parent = this.ControlBox_Min;
            this.ControlBox_Min.IconColor = System.Drawing.Color.White;
            this.ControlBox_Min.Location = new System.Drawing.Point(775, 1);
            this.ControlBox_Min.Name = "ControlBox_Min";
            this.ControlBox_Min.ShadowDecoration.Parent = this.ControlBox_Min;
            this.ControlBox_Min.Size = new System.Drawing.Size(37, 35);
            this.ControlBox_Min.TabIndex = 2;
            // 
            // ControlBox_Max
            // 
            this.ControlBox_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox_Max.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ControlBox_Max.FillColor = System.Drawing.SystemColors.ControlLight;
            this.ControlBox_Max.HoverState.Parent = this.ControlBox_Max;
            this.ControlBox_Max.IconColor = System.Drawing.Color.White;
            this.ControlBox_Max.Location = new System.Drawing.Point(812, 1);
            this.ControlBox_Max.Name = "ControlBox_Max";
            this.ControlBox_Max.ShadowDecoration.Parent = this.ControlBox_Max;
            this.ControlBox_Max.Size = new System.Drawing.Size(37, 35);
            this.ControlBox_Max.TabIndex = 1;
            // 
            // ControlBox_Close
            // 
            this.ControlBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox_Close.FillColor = System.Drawing.SystemColors.ControlLight;
            this.ControlBox_Close.HoverState.Parent = this.ControlBox_Close;
            this.ControlBox_Close.IconColor = System.Drawing.Color.White;
            this.ControlBox_Close.Location = new System.Drawing.Point(849, 1);
            this.ControlBox_Close.Name = "ControlBox_Close";
            this.ControlBox_Close.ShadowDecoration.Parent = this.ControlBox_Close;
            this.ControlBox_Close.Size = new System.Drawing.Size(37, 35);
            this.ControlBox_Close.TabIndex = 0;
            // 
            // DragMain
            // 
            this.DragMain.TargetControl = this.PHeader;
            // 
            // PMain
            // 
            this.PMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PMain.Location = new System.Drawing.Point(94, 40);
            this.PMain.Name = "PMain";
            this.PMain.Size = new System.Drawing.Size(886, 610);
            this.PMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_cafe_80px;
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnListUser
            // 
            this.btnListUser.BorderRadius = 6;
            this.btnListUser.CheckedState.FillColor = System.Drawing.Color.Navy;
            this.btnListUser.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListUser.CheckedState.Parent = this.btnListUser;
            this.btnListUser.CustomImages.Parent = this.btnListUser;
            this.btnListUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListUser.DisabledState.Parent = this.btnListUser;
            this.btnListUser.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnListUser.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.btnListUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListUser.ForeColor = System.Drawing.Color.White;
            this.btnListUser.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnListUser.HoverState.FillColor2 = System.Drawing.Color.Navy;
            this.btnListUser.HoverState.Parent = this.btnListUser;
            this.btnListUser.Image = global::GUI.Properties.Resources.icons8_registration_50px;
            this.btnListUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnListUser.Location = new System.Drawing.Point(12, 361);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.ShadowDecoration.Parent = this.btnListUser;
            this.btnListUser.Size = new System.Drawing.Size(70, 60);
            this.btnListUser.TabIndex = 3;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // btnListSanPham
            // 
            this.btnListSanPham.BorderRadius = 6;
            this.btnListSanPham.CheckedState.FillColor = System.Drawing.Color.Navy;
            this.btnListSanPham.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListSanPham.CheckedState.Parent = this.btnListSanPham;
            this.btnListSanPham.CustomImages.Parent = this.btnListSanPham;
            this.btnListSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListSanPham.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListSanPham.DisabledState.Parent = this.btnListSanPham;
            this.btnListSanPham.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnListSanPham.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.btnListSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListSanPham.ForeColor = System.Drawing.Color.White;
            this.btnListSanPham.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnListSanPham.HoverState.FillColor2 = System.Drawing.Color.Navy;
            this.btnListSanPham.HoverState.Parent = this.btnListSanPham;
            this.btnListSanPham.Image = global::GUI.Properties.Resources.icons8_features_list_50px;
            this.btnListSanPham.ImageSize = new System.Drawing.Size(40, 40);
            this.btnListSanPham.Location = new System.Drawing.Point(12, 295);
            this.btnListSanPham.Name = "btnListSanPham";
            this.btnListSanPham.ShadowDecoration.Parent = this.btnListSanPham;
            this.btnListSanPham.Size = new System.Drawing.Size(70, 60);
            this.btnListSanPham.TabIndex = 2;
            this.btnListSanPham.Click += new System.EventHandler(this.btnListSanPham_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BorderRadius = 6;
            this.btnDoanhThu.CheckedState.FillColor = System.Drawing.Color.Navy;
            this.btnDoanhThu.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDoanhThu.CheckedState.Parent = this.btnDoanhThu;
            this.btnDoanhThu.CustomImages.Parent = this.btnDoanhThu;
            this.btnDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoanhThu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoanhThu.DisabledState.Parent = this.btnDoanhThu;
            this.btnDoanhThu.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnDoanhThu.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.btnDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnDoanhThu.HoverState.FillColor2 = System.Drawing.Color.Navy;
            this.btnDoanhThu.HoverState.Parent = this.btnDoanhThu;
            this.btnDoanhThu.Image = global::GUI.Properties.Resources.icons8_bar_chart_50px_7;
            this.btnDoanhThu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDoanhThu.Location = new System.Drawing.Point(12, 229);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.ShadowDecoration.Parent = this.btnDoanhThu;
            this.btnDoanhThu.Size = new System.Drawing.Size(70, 60);
            this.btnDoanhThu.TabIndex = 1;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 6;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.Navy;
            this.btnHome.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.DisabledState.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.HoverState.FillColor2 = System.Drawing.Color.Navy;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageSize = new System.Drawing.Size(40, 40);
            this.btnHome.Location = new System.Drawing.Point(12, 163);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(70, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(982, 650);
            this.Controls.Add(this.PMain);
            this.Controls.Add(this.PHeader);
            this.Controls.Add(this.PLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.PLeft.ResumeLayout(false);
            this.PHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse eElipse;
        private System.Windows.Forms.Panel PHeader;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox_Min;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox_Max;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox_Close;
        private System.Windows.Forms.Panel PLeft;
        private Guna.UI2.WinForms.Guna2DragControl DragMain;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private Guna.UI2.WinForms.Guna2GradientButton btnListUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnListSanPham;
        private Guna.UI2.WinForms.Guna2GradientButton btnDoanhThu;
        private System.Windows.Forms.Panel PMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}