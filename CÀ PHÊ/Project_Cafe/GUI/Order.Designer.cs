
namespace GUI
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.gunaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnCheckout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTam = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.FLFood = new System.Windows.Forms.FlowLayoutPanel();
            this.LBTotal = new System.Windows.Forms.Label();
            this.LBMoney = new System.Windows.Forms.Label();
            this.InfoBillGird = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColNameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrintItem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBillGird)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbNameTable);
            this.panel1.Location = new System.Drawing.Point(18, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 41);
            this.panel1.TabIndex = 4;
            // 
            // lbNameTable
            // 
            this.lbNameTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNameTable.AutoSize = true;
            this.lbNameTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.Location = new System.Drawing.Point(141, 9);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(52, 21);
            this.lbNameTable.TabIndex = 5;
            this.lbNameTable.Text = "Bàn 1";
            this.lbNameTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaElipse
            // 
            this.gunaElipse.BorderRadius = 35;
            this.gunaElipse.TargetControl = this.panel1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCheckout.CheckedState.Parent = this.btnCheckout;
            this.btnCheckout.CustomImages.Parent = this.btnCheckout;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.DisabledState.Parent = this.btnCheckout;
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.HoverState.Parent = this.btnCheckout;
            this.btnCheckout.Location = new System.Drawing.Point(267, 560);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ShadowDecoration.Parent = this.btnCheckout;
            this.btnCheckout.Size = new System.Drawing.Size(102, 33);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Tính tiền";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnTam
            // 
            this.btnTam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTam.CheckedState.Parent = this.btnTam;
            this.btnTam.CustomImages.Parent = this.btnTam;
            this.btnTam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTam.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTam.DisabledState.Parent = this.btnTam;
            this.btnTam.FillColor = System.Drawing.Color.Green;
            this.btnTam.FillColor2 = System.Drawing.Color.DarkGreen;
            this.btnTam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTam.ForeColor = System.Drawing.Color.White;
            this.btnTam.HoverState.Parent = this.btnTam;
            this.btnTam.Location = new System.Drawing.Point(159, 560);
            this.btnTam.Name = "btnTam";
            this.btnTam.ShadowDecoration.Parent = this.btnTam;
            this.btnTam.Size = new System.Drawing.Size(102, 33);
            this.btnTam.TabIndex = 7;
            this.btnTam.Text = "Tạm tính";
            this.btnTam.Click += new System.EventHandler(this.btnTam_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMove.CheckedState.Parent = this.btnMove;
            this.btnMove.CustomImages.Parent = this.btnMove;
            this.btnMove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMove.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMove.DisabledState.Parent = this.btnMove;
            this.btnMove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMove.FillColor2 = System.Drawing.Color.Navy;
            this.btnMove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMove.ForeColor = System.Drawing.Color.White;
            this.btnMove.HoverState.Parent = this.btnMove;
            this.btnMove.Location = new System.Drawing.Point(18, 560);
            this.btnMove.Name = "btnMove";
            this.btnMove.ShadowDecoration.Parent = this.btnMove;
            this.btnMove.Size = new System.Drawing.Size(102, 33);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Chuyển bàn";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ItemHeight = 17;
            this.cbCategory.Items.AddRange(new object[] {
            "Cafe",
            "Cocktail",
            "Khác",
            "Nước",
            "Thức ăn"});
            this.cbCategory.Location = new System.Drawing.Point(18, 54);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(162, 25);
            this.cbCategory.TabIndex = 12;
            this.cbCategory.Text = "Theo loại";
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged);
            // 
            // cbPrice
            // 
            this.cbPrice.CausesValidation = false;
            this.cbPrice.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.ItemHeight = 17;
            this.cbPrice.Items.AddRange(new object[] {
            "Dưới 20K",
            "20K - 50K",
            "Trên 50K"});
            this.cbPrice.Location = new System.Drawing.Point(201, 54);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(168, 25);
            this.cbPrice.TabIndex = 13;
            this.cbPrice.Text = "Theo giá";
            this.cbPrice.SelectedValueChanged += new System.EventHandler(this.cbPrice_SelectedValueChanged);
            // 
            // FLFood
            // 
            this.FLFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FLFood.AutoScroll = true;
            this.FLFood.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FLFood.Location = new System.Drawing.Point(18, 87);
            this.FLFood.Name = "FLFood";
            this.FLFood.Padding = new System.Windows.Forms.Padding(5);
            this.FLFood.Size = new System.Drawing.Size(351, 222);
            this.FLFood.TabIndex = 14;
            // 
            // LBTotal
            // 
            this.LBTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LBTotal.AutoSize = true;
            this.LBTotal.Location = new System.Drawing.Point(3, 11);
            this.LBTotal.Name = "LBTotal";
            this.LBTotal.Size = new System.Drawing.Size(61, 13);
            this.LBTotal.TabIndex = 16;
            this.LBTotal.Text = "Thành tiền:";
            // 
            // LBMoney
            // 
            this.LBMoney.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LBMoney.ForeColor = System.Drawing.Color.DarkRed;
            this.LBMoney.Location = new System.Drawing.Point(70, 11);
            this.LBMoney.Name = "LBMoney";
            this.LBMoney.Size = new System.Drawing.Size(137, 13);
            this.LBMoney.TabIndex = 17;
            this.LBMoney.Text = "10000";
            this.LBMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InfoBillGird
            // 
            this.InfoBillGird.AllowUserToAddRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.InfoBillGird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.InfoBillGird.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InfoBillGird.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InfoBillGird.BackgroundColor = System.Drawing.Color.White;
            this.InfoBillGird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoBillGird.CausesValidation = false;
            this.InfoBillGird.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InfoBillGird.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoBillGird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.InfoBillGird.ColumnHeadersHeight = 30;
            this.InfoBillGird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNameFood,
            this.Column2,
            this.Column3,
            this.Column4,
            this.btnXoa});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoBillGird.DefaultCellStyle = dataGridViewCellStyle23;
            this.InfoBillGird.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.InfoBillGird.EnableHeadersVisualStyles = false;
            this.InfoBillGird.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.InfoBillGird.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InfoBillGird.Location = new System.Drawing.Point(18, 315);
            this.InfoBillGird.MultiSelect = false;
            this.InfoBillGird.Name = "InfoBillGird";
            this.InfoBillGird.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoBillGird.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.InfoBillGird.RowHeadersVisible = false;
            this.InfoBillGird.RowHeadersWidth = 50;
            this.InfoBillGird.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.InfoBillGird.Size = new System.Drawing.Size(351, 197);
            this.InfoBillGird.TabIndex = 18;
            this.InfoBillGird.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.InfoBillGird.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.InfoBillGird.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.InfoBillGird.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.InfoBillGird.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.InfoBillGird.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.InfoBillGird.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.InfoBillGird.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.InfoBillGird.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.InfoBillGird.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.InfoBillGird.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBillGird.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.InfoBillGird.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.InfoBillGird.ThemeStyle.HeaderStyle.Height = 30;
            this.InfoBillGird.ThemeStyle.ReadOnly = false;
            this.InfoBillGird.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.InfoBillGird.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InfoBillGird.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.InfoBillGird.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.InfoBillGird.ThemeStyle.RowsStyle.Height = 22;
            this.InfoBillGird.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.InfoBillGird.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ColNameFood
            // 
            this.ColNameFood.FillWeight = 90F;
            this.ColNameFood.HeaderText = "Tên món";
            this.ColNameFood.Name = "ColNameFood";
            this.ColNameFood.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle21.Format = "N0";
            dataGridViewCellStyle21.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle22.Format = "C0";
            dataGridViewCellStyle22.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column3.FillWeight = 78.6719F;
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 78.6719F;
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.Name = "Column4";
            // 
            // btnXoa
            // 
            this.btnXoa.FillWeight = 35.55792F;
            this.btnXoa.HeaderText = "";
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_delete_24px_1;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ReadOnly = true;
            this.btnXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnPrintItem
            // 
            this.btnPrintItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrintItem.BorderColor = System.Drawing.Color.White;
            this.btnPrintItem.CheckedState.Parent = this.btnPrintItem;
            this.btnPrintItem.CustomImages.Parent = this.btnPrintItem;
            this.btnPrintItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintItem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintItem.DisabledState.Parent = this.btnPrintItem;
            this.btnPrintItem.FillColor = System.Drawing.Color.White;
            this.btnPrintItem.FillColor2 = System.Drawing.Color.White;
            this.btnPrintItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrintItem.ForeColor = System.Drawing.Color.Black;
            this.btnPrintItem.HoverState.Parent = this.btnPrintItem;
            this.btnPrintItem.Location = new System.Drawing.Point(18, 520);
            this.btnPrintItem.Name = "btnPrintItem";
            this.btnPrintItem.ShadowDecoration.Parent = this.btnPrintItem;
            this.btnPrintItem.Size = new System.Drawing.Size(102, 33);
            this.btnPrintItem.TabIndex = 19;
            this.btnPrintItem.Text = "In tem";
            this.btnPrintItem.Click += new System.EventHandler(this.btnPrintItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LBTotal);
            this.panel2.Controls.Add(this.LBMoney);
            this.panel2.Location = new System.Drawing.Point(159, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 34);
            this.panel2.TabIndex = 20;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 35.55792F;
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.icons8_cancel_24px_2;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 33;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPrintItem);
            this.Controls.Add(this.InfoBillGird);
            this.Controls.Add(this.FLFood);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnTam);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(386, 600);
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBillGird)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse gunaElipse;
        private System.Windows.Forms.Label lbNameTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckout;
        private Guna.UI2.WinForms.Guna2GradientButton btnTam;
        private Guna.UI2.WinForms.Guna2GradientButton btnMove;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.FlowLayoutPanel FLFood;
        private System.Windows.Forms.Label LBTotal;
        private System.Windows.Forms.Label LBMoney;
        private Guna.UI2.WinForms.Guna2DataGridView InfoBillGird;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2GradientButton btnPrintItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn btnXoa;
    }
}
