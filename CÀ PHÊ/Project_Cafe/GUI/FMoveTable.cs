using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FMoveTable : Form
    {
        public int idTable;
        public int idBill;

        public FMoveTable(string name)
        {
            InitializeComponent();
            LoadTableMove();
            btnTableCurrent.Text = name;


        }

        public int IdTable { get => idTable; set => idTable = value; }
        public int IdBill { get => idBill; set => idBill = value; }


        public void LoadTableMove()
        {
            List<TableFood> tableFoods = BUS_TableFood.Instance.getTableFood();
            foreach (TableFood table in tableFoods)
            {
                Button button = new Button();
                switch (table.Status)
                {
                    case "Có người":
                        button.BackColor = System.Drawing.Color.LightGreen;
                        button.Visible = false;
                        break;
                    case "Bàn đặt":
                        button.BackColor = System.Drawing.Color.Coral;
                        button.Visible = false;
                        break;
                    default:
                        button.BackColor = System.Drawing.SystemColors.ScrollBar;
                        break;
                }
                button.Tag = table;
                button.Image = global::GUI.Properties.Resources.icons8_table_top_view_50px;
                button.Location = new System.Drawing.Point(3, 3);
                button.Size = new System.Drawing.Size(80, 75);
                button.TabIndex = 3;
                button.Text = "" + table.Name.ToString();
                button.Click += btnXacNhan;
                FlowTable.Controls.Add(button);
            }
        }

        private void btnXacNhan(object sender, EventArgs e)
        {
            int idtableTo = ((sender as Button).Tag as TableFood).Id;
            BUS_TableFood.Instance.MoveTable(IdTable, "Trống", idtableTo, IdBill, "Có người", idtableTo);
            //BUS_Bill.Instance.UpdateBill(idtableTo, IdBill);
            //BUS_TableFood.Instance.UpdateStatusTable(IdTable, "Trống");
            //BUS_TableFood.Instance.UpdateStatusTable(idtableTo, "Có người");
            this.Hide();
        }
    }
}
