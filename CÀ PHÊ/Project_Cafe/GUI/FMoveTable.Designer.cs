
namespace GUI
{
    partial class FMoveTable
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
            this.ElipseMoveTable = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PMove = new System.Windows.Forms.Panel();
            this.LbMoveTable = new System.Windows.Forms.Label();
            this.CClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.FlowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.imgTo = new System.Windows.Forms.PictureBox();
            this.btnTableCurrent = new System.Windows.Forms.Button();
            this.PMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTo)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseMoveTable
            // 
            this.ElipseMoveTable.TargetControl = this;
            // 
            // PMove
            // 
            this.PMove.Controls.Add(this.imgTo);
            this.PMove.Controls.Add(this.FlowTable);
            this.PMove.Controls.Add(this.btnTableCurrent);
            this.PMove.Controls.Add(this.LbMoveTable);
            this.PMove.Controls.Add(this.CClose);
            this.PMove.Location = new System.Drawing.Point(0, 0);
            this.PMove.Name = "PMove";
            this.PMove.Size = new System.Drawing.Size(285, 227);
            this.PMove.TabIndex = 0;
            // 
            // LbMoveTable
            // 
            this.LbMoveTable.AutoSize = true;
            this.LbMoveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMoveTable.Location = new System.Drawing.Point(7, 8);
            this.LbMoveTable.Name = "LbMoveTable";
            this.LbMoveTable.Size = new System.Drawing.Size(107, 20);
            this.LbMoveTable.TabIndex = 1;
            this.LbMoveTable.Text = "Chuyển bàn";
            // 
            // CClose
            // 
            this.CClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CClose.BackColor = System.Drawing.SystemColors.Control;
            this.CClose.FillColor = System.Drawing.SystemColors.Control;
            this.CClose.HoverState.Parent = this.CClose;
            this.CClose.IconColor = System.Drawing.Color.White;
            this.CClose.Location = new System.Drawing.Point(245, 4);
            this.CClose.Name = "CClose";
            this.CClose.ShadowDecoration.Parent = this.CClose;
            this.CClose.Size = new System.Drawing.Size(34, 24);
            this.CClose.TabIndex = 0;
            // 
            // FlowTable
            // 
            this.FlowTable.AutoScroll = true;
            this.FlowTable.Location = new System.Drawing.Point(172, 36);
            this.FlowTable.Name = "FlowTable";
            this.FlowTable.Size = new System.Drawing.Size(104, 159);
            this.FlowTable.TabIndex = 3;
            // 
            // imgTo
            // 
            this.imgTo.Image = global::GUI.Properties.Resources.icons8_arrow_48px;
            this.imgTo.Location = new System.Drawing.Point(97, 86);
            this.imgTo.Name = "imgTo";
            this.imgTo.Size = new System.Drawing.Size(54, 50);
            this.imgTo.TabIndex = 4;
            this.imgTo.TabStop = false;
            // 
            // btnTableCurrent
            // 
            this.btnTableCurrent.Image = global::GUI.Properties.Resources.icons8_table_top_view_50px;
            this.btnTableCurrent.Location = new System.Drawing.Point(11, 72);
            this.btnTableCurrent.Name = "btnTableCurrent";
            this.btnTableCurrent.Size = new System.Drawing.Size(80, 75);
            this.btnTableCurrent.TabIndex = 2;
            this.btnTableCurrent.Text = "1";
            this.btnTableCurrent.UseVisualStyleBackColor = true;
            // 
            // FMoveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 233);
            this.Controls.Add(this.PMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMoveTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FMoveTable";
            this.PMove.ResumeLayout(false);
            this.PMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse ElipseMoveTable;
        private System.Windows.Forms.Panel PMove;
        private Guna.UI2.WinForms.Guna2ControlBox CClose;
        private System.Windows.Forms.Label LbMoveTable;
        private System.Windows.Forms.Button btnTableCurrent;
        private System.Windows.Forms.FlowLayoutPanel FlowTable;
        private System.Windows.Forms.PictureBox imgTo;
    }
}