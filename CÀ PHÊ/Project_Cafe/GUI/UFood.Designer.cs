
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class UFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFood));
            this.LNameFood = new System.Windows.Forms.Label();
            this.LPrice = new System.Windows.Forms.Label();
            this.PrImageFood = new System.Windows.Forms.PictureBox();
            this.LAddFood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrImageFood)).BeginInit();
            this.SuspendLayout();
            // 
            // LNameFood
            // 
            this.LNameFood.AutoSize = true;
            this.LNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LNameFood.Location = new System.Drawing.Point(93, 14);
            this.LNameFood.Name = "LNameFood";
            this.LNameFood.Size = new System.Drawing.Size(135, 15);
            this.LNameFood.TabIndex = 1;
            this.LNameFood.Text = "Trà xanh trân châu I";
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LPrice.Location = new System.Drawing.Point(93, 36);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(50, 13);
            this.LPrice.TabIndex = 2;
            this.LPrice.Text = "45.000 đ";
            // 
            // PrImageFood
            // 
            this.PrImageFood.Image = ((System.Drawing.Image)(resources.GetObject("PrImageFood.Image")));
            this.PrImageFood.Location = new System.Drawing.Point(4, 4);
            this.PrImageFood.Name = "PrImageFood";
            this.PrImageFood.Size = new System.Drawing.Size(68, 57);
            this.PrImageFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrImageFood.TabIndex = 0;
            this.PrImageFood.TabStop = false;
            // 
            // LAddFood
            // 
            this.LAddFood.AutoSize = true;
            this.LAddFood.Image = global::GUI.Properties.Resources.icons8_add_24px;
            this.LAddFood.Location = new System.Drawing.Point(273, 22);
            this.LAddFood.Name = "LAddFood";
            this.LAddFood.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.LAddFood.Size = new System.Drawing.Size(24, 23);
            this.LAddFood.TabIndex = 3;
            this.LAddFood.Click += new System.EventHandler(this.LAddFood_Click);
            // 
            // UFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LAddFood);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.LNameFood);
            this.Controls.Add(this.PrImageFood);
            this.Name = "UFood";
            this.Size = new System.Drawing.Size(320, 66);
            ((System.ComponentModel.ISupportInitialize)(this.PrImageFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PrImageFood;
        private System.Windows.Forms.Label LNameFood;
        private System.Windows.Forms.Label LPrice;
        public System.Windows.Forms.Label LAddFood;
    }
}
