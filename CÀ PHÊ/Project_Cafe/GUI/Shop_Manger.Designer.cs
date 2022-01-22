
namespace GUI
{
    partial class Shop_Manger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pHeaderTable = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.BoHeader = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataViewTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNameTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.TTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DataViewFood = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TFood = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgFood = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdateFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.pHeaderTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeaderTable
            // 
            this.pHeaderTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHeaderTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pHeaderTable.Controls.Add(this.lbTitle);
            this.pHeaderTable.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.pHeaderTable.Location = new System.Drawing.Point(211, 3);
            this.pHeaderTable.Name = "pHeaderTable";
            this.pHeaderTable.Size = new System.Drawing.Size(485, 41);
            this.pHeaderTable.TabIndex = 12;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(174, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(153, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "QUẢN LÝ CỬA HÀNG";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoHeader
            // 
            this.BoHeader.BorderRadius = 35;
            this.BoHeader.TargetControl = this.pHeaderTable;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.guna2GroupBox2);
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Location = new System.Drawing.Point(16, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 560);
            this.panel1.TabIndex = 15;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.Controls.Add(this.DataViewFood);
            this.guna2GroupBox2.Controls.Add(this.btnUpdateFood);
            this.guna2GroupBox2.Controls.Add(this.btnAddFood);
            this.guna2GroupBox2.Controls.Add(this.btnImage);
            this.guna2GroupBox2.Controls.Add(this.cbType);
            this.guna2GroupBox2.Controls.Add(this.txtPrice);
            this.guna2GroupBox2.Controls.Add(this.txtImage);
            this.guna2GroupBox2.Controls.Add(this.txtNameFood);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(346, 15);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(504, 542);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Món ăn";
            // 
            // cbType
            // 
            this.cbType.AccessibleName = "";
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderRadius = 15;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.Parent = this.cbType;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.HoverState.Parent = this.cbType;
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbType.ItemsAppearance.Parent = this.cbType;
            this.cbType.Location = new System.Drawing.Point(215, 112);
            this.cbType.Name = "cbType";
            this.cbType.ShadowDecoration.Parent = this.cbType;
            this.cbType.Size = new System.Drawing.Size(171, 36);
            this.cbType.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.LightGray;
            this.txtPrice.BorderRadius = 15;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(215, 57);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Đơn giá";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(171, 36);
            this.txtPrice.TabIndex = 3;
            // 
            // txtImage
            // 
            this.txtImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImage.BackColor = System.Drawing.Color.White;
            this.txtImage.BorderColor = System.Drawing.Color.LightGray;
            this.txtImage.BorderRadius = 15;
            this.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImage.DefaultText = "";
            this.txtImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.DisabledState.Parent = this.txtImage;
            this.txtImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImage.FocusedState.Parent = this.txtImage;
            this.txtImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImage.HoverState.Parent = this.txtImage;
            this.txtImage.Location = new System.Drawing.Point(27, 112);
            this.txtImage.Name = "txtImage";
            this.txtImage.PasswordChar = '\0';
            this.txtImage.PlaceholderText = "Ảnh";
            this.txtImage.SelectedText = "";
            this.txtImage.ShadowDecoration.Parent = this.txtImage;
            this.txtImage.Size = new System.Drawing.Size(124, 36);
            this.txtImage.TabIndex = 2;
            // 
            // txtNameFood
            // 
            this.txtNameFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNameFood.BackColor = System.Drawing.Color.White;
            this.txtNameFood.BorderColor = System.Drawing.Color.LightGray;
            this.txtNameFood.BorderRadius = 15;
            this.txtNameFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameFood.DefaultText = "";
            this.txtNameFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFood.DisabledState.Parent = this.txtNameFood;
            this.txtNameFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFood.FocusedState.Parent = this.txtNameFood;
            this.txtNameFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFood.HoverState.Parent = this.txtNameFood;
            this.txtNameFood.Location = new System.Drawing.Point(27, 57);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.PasswordChar = '\0';
            this.txtNameFood.PlaceholderText = "Tên món";
            this.txtNameFood.SelectedText = "";
            this.txtNameFood.ShadowDecoration.Parent = this.txtNameFood;
            this.txtNameFood.Size = new System.Drawing.Size(171, 36);
            this.txtNameFood.TabIndex = 1;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.Controls.Add(this.DataViewTable);
            this.guna2GroupBox1.Controls.Add(this.btnUpdateTable);
            this.guna2GroupBox1.Controls.Add(this.btnAddTable);
            this.guna2GroupBox1.Controls.Add(this.guna2ComboBox2);
            this.guna2GroupBox1.Controls.Add(this.txtNameTable);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 15);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(337, 542);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Bàn ăn";
            // 
            // DataViewTable
            // 
            this.DataViewTable.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataViewTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataViewTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataViewTable.ColumnHeadersHeight = 30;
            this.DataViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataViewTable.EnableHeadersVisualStyles = false;
            this.DataViewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewTable.Location = new System.Drawing.Point(22, 237);
            this.DataViewTable.Name = "DataViewTable";
            this.DataViewTable.RowHeadersVisible = false;
            this.DataViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewTable.Size = new System.Drawing.Size(289, 259);
            this.DataViewTable.TabIndex = 6;
            this.DataViewTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataViewTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataViewTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataViewTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataViewTable.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataViewTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataViewTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataViewTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataViewTable.ThemeStyle.HeaderStyle.Height = 30;
            this.DataViewTable.ThemeStyle.ReadOnly = false;
            this.DataViewTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataViewTable.ThemeStyle.RowsStyle.Height = 22;
            this.DataViewTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataViewTable.SelectionChanged += new System.EventHandler(this.DataViewTable_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "#ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 142.3858F;
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 142.3858F;
            this.Column3.HeaderText = "Phòng";
            this.Column3.Name = "Column3";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 15;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Tầng 1",
            "Tâng 2",
            "Tầng 3",
            "Tâng 4"});
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(48, 112);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(239, 36);
            this.guna2ComboBox2.TabIndex = 2;
            // 
            // txtNameTable
            // 
            this.txtNameTable.BackColor = System.Drawing.Color.White;
            this.txtNameTable.BorderColor = System.Drawing.Color.LightGray;
            this.txtNameTable.BorderRadius = 15;
            this.txtNameTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameTable.DefaultText = "";
            this.txtNameTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameTable.DisabledState.Parent = this.txtNameTable;
            this.txtNameTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameTable.FocusedState.Parent = this.txtNameTable;
            this.txtNameTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameTable.HoverState.Parent = this.txtNameTable;
            this.txtNameTable.Location = new System.Drawing.Point(48, 57);
            this.txtNameTable.Name = "txtNameTable";
            this.txtNameTable.PasswordChar = '\0';
            this.txtNameTable.PlaceholderText = "Tên bàn";
            this.txtNameTable.SelectedText = "";
            this.txtNameTable.ShadowDecoration.Parent = this.txtNameTable;
            this.txtNameTable.Size = new System.Drawing.Size(239, 36);
            this.txtNameTable.TabIndex = 0;
            // 
            // TTable
            // 
            this.TTable.BorderRadius = 10;
            this.TTable.TargetControl = this.DataViewTable;
            // 
            // DataViewFood
            // 
            this.DataViewFood.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataViewFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewFood.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataViewFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataViewFood.ColumnHeadersHeight = 30;
            this.DataViewFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4,
            this.imgFood});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataViewFood.EnableHeadersVisualStyles = false;
            this.DataViewFood.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewFood.Location = new System.Drawing.Point(27, 237);
            this.DataViewFood.Name = "DataViewFood";
            this.DataViewFood.RowHeadersVisible = false;
            this.DataViewFood.RowHeadersWidth = 50;
            this.DataViewFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewFood.Size = new System.Drawing.Size(456, 259);
            this.DataViewFood.TabIndex = 7;
            this.DataViewFood.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewFood.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataViewFood.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataViewFood.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataViewFood.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataViewFood.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataViewFood.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewFood.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataViewFood.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataViewFood.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewFood.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewFood.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataViewFood.ThemeStyle.HeaderStyle.Height = 30;
            this.DataViewFood.ThemeStyle.ReadOnly = false;
            this.DataViewFood.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewFood.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewFood.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewFood.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataViewFood.ThemeStyle.RowsStyle.Height = 22;
            this.DataViewFood.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewFood.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataViewFood.SelectionChanged += new System.EventHandler(this.DataViewFood_SelectionChanged);
            // 
            // TFood
            // 
            this.TFood.BorderRadius = 10;
            this.TFood.TargetControl = this.DataViewFood;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "#ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 142.3858F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên món";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 142.3858F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại";
            this.Column4.Name = "Column4";
            // 
            // imgFood
            // 
            this.imgFood.HeaderText = "Ảnh";
            this.imgFood.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgFood.Name = "imgFood";
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateFood.BackColor = System.Drawing.Color.White;
            this.btnUpdateFood.BorderRadius = 15;
            this.btnUpdateFood.CheckedState.Parent = this.btnUpdateFood;
            this.btnUpdateFood.CustomImages.Parent = this.btnUpdateFood;
            this.btnUpdateFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateFood.DisabledState.Parent = this.btnUpdateFood;
            this.btnUpdateFood.FillColor = System.Drawing.Color.Green;
            this.btnUpdateFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateFood.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFood.HoverState.Parent = this.btnUpdateFood;
            this.btnUpdateFood.Image = global::GUI.Properties.Resources.icons8_update_user_24px;
            this.btnUpdateFood.Location = new System.Drawing.Point(431, 112);
            this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.ShadowDecoration.Parent = this.btnUpdateFood;
            this.btnUpdateFood.Size = new System.Drawing.Size(42, 37);
            this.btnUpdateFood.TabIndex = 4;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddFood.BackColor = System.Drawing.Color.White;
            this.btnAddFood.BorderRadius = 15;
            this.btnAddFood.CheckedState.Parent = this.btnAddFood;
            this.btnAddFood.CustomImages.Parent = this.btnAddFood;
            this.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFood.DisabledState.Parent = this.btnAddFood;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.HoverState.Parent = this.btnAddFood;
            this.btnAddFood.Image = global::GUI.Properties.Resources.icons8_add_24px_4;
            this.btnAddFood.Location = new System.Drawing.Point(431, 57);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.ShadowDecoration.Parent = this.btnAddFood;
            this.btnAddFood.Size = new System.Drawing.Size(42, 37);
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnImage
            // 
            this.btnImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImage.BackColor = System.Drawing.Color.White;
            this.btnImage.BorderRadius = 15;
            this.btnImage.CheckedState.Parent = this.btnImage;
            this.btnImage.CustomImages.Parent = this.btnImage;
            this.btnImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImage.DisabledState.Parent = this.btnImage;
            this.btnImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.HoverState.Parent = this.btnImage;
            this.btnImage.Image = global::GUI.Properties.Resources.icons8_image_24px;
            this.btnImage.Location = new System.Drawing.Point(156, 112);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnImage.Name = "btnImage";
            this.btnImage.ShadowDecoration.Parent = this.btnImage;
            this.btnImage.Size = new System.Drawing.Size(42, 37);
            this.btnImage.TabIndex = 5;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.BackColor = System.Drawing.Color.White;
            this.btnUpdateTable.BorderRadius = 15;
            this.btnUpdateTable.CheckedState.Parent = this.btnUpdateTable;
            this.btnUpdateTable.CustomImages.Parent = this.btnUpdateTable;
            this.btnUpdateTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateTable.DisabledState.Parent = this.btnUpdateTable;
            this.btnUpdateTable.FillColor = System.Drawing.Color.Green;
            this.btnUpdateTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateTable.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTable.HoverState.Parent = this.btnUpdateTable;
            this.btnUpdateTable.Image = global::GUI.Properties.Resources.icons8_update_user_24px;
            this.btnUpdateTable.Location = new System.Drawing.Point(173, 153);
            this.btnUpdateTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.ShadowDecoration.Parent = this.btnUpdateTable;
            this.btnUpdateTable.Size = new System.Drawing.Size(42, 37);
            this.btnUpdateTable.TabIndex = 5;
            this.btnUpdateTable.Click += new System.EventHandler(this.btnUpdateTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.White;
            this.btnAddTable.BorderRadius = 15;
            this.btnAddTable.CheckedState.Parent = this.btnAddTable;
            this.btnAddTable.CustomImages.Parent = this.btnAddTable;
            this.btnAddTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTable.DisabledState.Parent = this.btnAddTable;
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.HoverState.Parent = this.btnAddTable;
            this.btnAddTable.Image = global::GUI.Properties.Resources.icons8_add_24px_4;
            this.btnAddTable.Location = new System.Drawing.Point(111, 153);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.ShadowDecoration.Parent = this.btnAddTable;
            this.btnAddTable.Size = new System.Drawing.Size(42, 37);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // Shop_Manger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pHeaderTable);
            this.Name = "Shop_Manger";
            this.Size = new System.Drawing.Size(886, 610);
            this.pHeaderTable.ResumeLayout(false);
            this.pHeaderTable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeaderTable;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2Elipse BoHeader;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtNameTable;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button btnAddTable;
        private Guna.UI2.WinForms.Guna2Button btnUpdateFood;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtImage;
        private Guna.UI2.WinForms.Guna2TextBox txtNameFood;
        private Guna.UI2.WinForms.Guna2Button btnImage;
        private Guna.UI2.WinForms.Guna2Button btnAddFood;
        private Guna.UI2.WinForms.Guna2Button btnUpdateTable;
        private Guna.UI2.WinForms.Guna2DataGridView DataViewTable;
        private Guna.UI2.WinForms.Guna2Elipse TTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2DataGridView DataViewFood;
        private Guna.UI2.WinForms.Guna2Elipse TFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn imgFood;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
    }
}
