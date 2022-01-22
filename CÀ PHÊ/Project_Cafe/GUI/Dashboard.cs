using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : UserControl
    {

        public Dashboard()
        {
            InitializeComponent();
            LoadTable();
        }
        public void LoadTable()
        {
            pTable.Controls.Clear();
            List<TableFood> tableFoods = BUS_TableFood.Instance.getTableFood();
            foreach (TableFood table in tableFoods)
            {
                Button button = new Button();
                switch (table.Status)
                {
                    case "Có người":
                        button.BackColor = System.Drawing.Color.LightGreen;
                        break;
                    case "Bàn đặt":
                        button.BackColor = System.Drawing.Color.Coral;
                        break;
                    default:
                        button.BackColor = System.Drawing.SystemColors.ScrollBar;
                        break;
                }

                button.Cursor = System.Windows.Forms.Cursors.Hand;
                button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.SystemColors.ControlText;
                button.Image = global::GUI.Properties.Resources.icons8_table_top_view_50px;
                button.Size = new System.Drawing.Size(115, 101);
                button.TabIndex = 0;
                button.Text = table.Name;
                button.UseVisualStyleBackColor = false;
                button.Tag = table;
                button.Click += btn_Click;
                pTable.Controls.Add(button);

            }
        }



        public void btn_Click(object sender, EventArgs e)
        {
            string name = ((sender as Button).Tag as TableFood).Name;
            int idtable = ((sender as Button).Tag as TableFood).Id;
            Order order = new Order();
            order.NameTable = name;
            order.IdTable = idtable;
            order.LoadBillInfo();
            //order.LoadBill();
            order.LoadData();
            showControl(order);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

            Custom custom = new Custom();
            showControl(custom);
        }
        public void showControl(Control control)
        {
            pOrder.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pOrder.Controls.Add(control);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LBLoad_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
