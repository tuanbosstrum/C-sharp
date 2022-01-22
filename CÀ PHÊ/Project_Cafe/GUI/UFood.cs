using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class UFood : UserControl
    {
        public string imageFood;
        public string nameFood;
        public string price;
        public int idTable;
        public int idFood;
        public Label label_;

        public UFood()
        {
            InitializeComponent();
            label_ = LAddFood;
        }
        public void getLoadFood()
        {
            Bitmap bitmap = new Bitmap(Application.StartupPath + @"\Images\Uploads\" + ImageFood);
            PrImageFood.Image = bitmap;
            LNameFood.Text = NameFood;
            LPrice.Text = Price;
        }

        public string ImageFood { get => imageFood; set => imageFood = value; }
        public string NameFood { get => nameFood; set => nameFood = value; }
        public string Price { get => price; set => price = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public Label Label_ { get => label_; set => label_ = value; }

        public void LAddFood_Click(object sender, EventArgs e)
        {

            Bill bill = BUS_Bill.Instance.getBillByIdTable(IdTable);
            int idbill = bill.Id;
            if (idbill == 0)
            {
                BUS_Bill.Instance.InsertBill(IdTable);
                BUS_BillInfo.Instance.InsertBillInfo(idbill, IdFood, 1);
            }
            else
            {
                List<BillInfo> bills = BUS_BillInfo.Instance.getBillInfoByIdBill(idbill);
                bool check = true;
                foreach (BillInfo info in bills)
                {
                    if (info.IdFood == IdFood)
                    {

                        BUS_BillInfo.Instance.UpdateBillInfo(info.Count + 1, info.Id);
                        check = false;
                    }
                }
                if (check == true)
                {
                    BUS_BillInfo.Instance.InsertBillInfo(idbill, IdFood, 1);
                    BUS_TableFood.Instance.UpdateStatusTable(IdTable, "Có người");
                }
            }
        }
    }
}
