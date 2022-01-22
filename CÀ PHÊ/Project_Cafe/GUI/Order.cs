using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class Order : UserControl
    {
        static Order instance;
        public string nameTable;
        public int idTable;
        public Order()
        {
            InitializeComponent();

        }
        public void LoadBillInfo()
        {
            InfoBillGird.Rows.Clear();
            List<ItemBill> listitems = BUS_ItemBill.Instance.getListItemByTable(IdTable);
            double total = 0;
            foreach (ItemBill item in listitems)
            {
                InfoBillGird.Rows.Add(new Object[] {
                item.FoodName,
                item.Count,
                item.Price,
                null
                });

                total += item.Price * item.Count;

            }
            InfoBillGird.CellDoubleClick += btnMoveItem;
            LBMoney.Text = total.ToString("C").Replace(",00", "");
        }

        private void btnMoveItem(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string name = Convert.ToString(InfoBillGird.Rows[e.RowIndex].Cells["ColNameFood"].FormattedValue.ToString());
                List<Foods> foods = BUS_Food.Instance.getListFood();
                Bill bill = BUS_Bill.Instance.getBillByIdTable(IdTable);
                int idBill = bill.Id;
                int tmpIdFood = 0;
                foreach (Foods food in foods)
                {
                    if (food.NameFood.Equals(name))
                    {
                        tmpIdFood = food.IdFood;
                        break;
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    BUS_BillInfo.Instance.DelBillInfo(idBill, tmpIdFood);
                    LoadBillInfo();
                }
            }
            catch (Exception)
            {

            }

        }

        public void LoadData()
        {
            lbNameTable.Text = "Bàn " + NameTable;
        }
        //public void LoadBill()
        //{
        //    LVBill.Items.Clear();
        //    double total = 0;
        //    List<ItemBill> listitems = BUS_ItemBill.Instance.getListItemByTable(IdTable);
        //    foreach(ItemBill item  in listitems)
        //    {
        //        ListViewItem viewItem = new ListViewItem(item.FoodName);
        //        viewItem.SubItems.Add(item.Count.ToString());
        //        viewItem.SubItems.Add(item.Price.ToString());
        //        total += item.Price * item.Count;
        //        LVBill.Items.Add(viewItem);

        //    }
        //    LBMoney.Text = total.ToString("C").Replace(",00", "");


        //}

        public string NameTable { get => nameTable; set => nameTable = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public static Order Instance
        {
            get
            {
                if (instance == null)
                    instance = new Order();
                return instance;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            OrderLoad();

        }
        public void showControl(Control control)
        {

            FLFood.Controls.Add(control);
        }
        public void ListFoodByPrice(int price)
        {
            FLFood.Controls.Clear();
            List<Foods> listfood = BUS_Food.Instance.ListFoodByPrice(price);
            foreach (Foods food in listfood)
            {
                UFood ufood = new UFood();
                ufood.IdFood = food.IdFood;
                ufood.IdTable = IdTable;
                ufood.ImageFood = food.ImageFood;
                ufood.NameFood = food.NameFood;
                ufood.Label_.Click += LAddFood_Click;
                ufood.Price = food.PriceFood.ToString("C").Replace(",00", "");
                ufood.getLoadFood();

                showControl(ufood);
            }
        }
        public void ListFoodByCate(string name)
        {
            FLFood.Controls.Clear();
            List<Foods> listfood = BUS_Food.Instance.ListFoodByCate(name);
            foreach (Foods food in listfood)
            {
                UFood ufood = new UFood();
                ufood.IdFood = food.IdFood;
                ufood.IdTable = IdTable;
                ufood.ImageFood = food.ImageFood;
                ufood.NameFood = food.NameFood;
                ufood.Label_.Click += LAddFood_Click;
                ufood.Price = food.PriceFood.ToString("C").Replace(",00", "");
                ufood.getLoadFood();

                showControl(ufood);
            }
        }
        public void OrderLoad()
        {
            FLFood.Controls.Clear();
            List<Foods> listfood = BUS_Food.Instance.getListFood();
            foreach (Foods food in listfood)
            {
                UFood ufood = new UFood();
                ufood.IdFood = food.IdFood;
                ufood.IdTable = IdTable;
                ufood.ImageFood = food.ImageFood;
                ufood.NameFood = food.NameFood;
                ufood.Label_.Click += LAddFood_Click;
                ufood.Price = food.PriceFood.ToString("C").Replace(",00", "");
                ufood.getLoadFood();

                showControl(ufood);
            }
        }

        private void LAddFood_Click(object sender, EventArgs e)
        {
            //LoadBill();
            LoadBillInfo();
        }

        private void btnTam_Click(object sender, EventArgs e)
        {
            List<ItemBill> listitems = BUS_ItemBill.Instance.getListItemByTable(IdTable);
            double total = 0;
            foreach (ItemBill item in listitems)
            {
                total += item.Price * item.Count;
            }
            RPBill pBill = new RPBill(listitems , total);
            pBill.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<ItemBill> listitems = BUS_ItemBill.Instance.getListItemByTable(IdTable);
            float total = 0f;
            foreach (ItemBill item in listitems)
            {
                total += Convert.ToInt32(item.Price * item.Count);
            }
            Bill bill = BUS_Bill.Instance.getBillByIdTable(IdTable);
            int idBill = bill.Id;
            BUS_Bill.Instance.CheckOutBill(idBill, total);
            BUS_TableFood.Instance.UpdateStatusTable(IdTable, "Trống");
            LoadBillInfo();
            RPCheckOut rPCheck = new RPCheckOut(listitems, total,bill);
            rPCheck.ShowDialog();

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Bill bill = BUS_Bill.Instance.getBillByIdTable(IdTable);
            int idBill = bill.Id;
            FMoveTable fMove = new FMoveTable(NameTable);
            fMove.IdTable = IdTable;
            fMove.IdBill = idBill;
            fMove.ShowDialog();
        }

        private void btnPrintItem_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ListFoodByCate(cbCategory.SelectedItem.ToString());
        }

        private void cbPrice_SelectedValueChanged(object sender, EventArgs e)
        {
            string type = cbPrice.SelectedItem.ToString();
            int price = 0;
            switch (type)
            {
                case "Dưới 20K":
                    price = 19999;
                    break;
                case "20K - 50K":
                    price = 20000;
                    break;
                case "Trên 50K":
                    price = 50001;
                    break;
                default:
                    break;
            }
            ListFoodByPrice(price);
        }
    }
}
