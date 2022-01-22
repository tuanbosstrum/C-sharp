using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class Shop_Manger : UserControl
    {
        private int idTable;
        private int idFood;
        public Shop_Manger()
        {
            InitializeComponent();
            LoadTable();
            LoadFood();
            LoadCateToCombox();
        }
        public void LoadCateToCombox()
        {
            cbType.Items.Clear();
            List<Category> categories = BUS_Category.Instance.GetCategories();
            foreach (Category category in categories)
            {
                cbType.Items.Add(category.Name);

            }


        }
        public void UpdateTable(int idTable, string name)
        {
            BUS_TableFood.Instance.UpdateTable(idTable, name);
            LoadTable();
        }
        public void InsertTable(string name)
        {
            BUS_TableFood.Instance.InsertTable(name);
            LoadTable();
        }
        public void LoadFood()
        {
            DataViewFood.Rows.Clear();
            List<Foods> foods = BUS_Food.Instance.getListFood();
            foreach (Foods food in foods)
            {
                string namecate = "";
                List<Category> categories = BUS_Category.Instance.GetCategories();
                foreach (Category category in categories)
                {
                    if (category.Id == food.Id_categoryFood)
                    {
                        namecate = category.Name;
                    }

                }
                DataViewFood.Rows.Add(new object[] {
                food.IdFood,
                food.NameFood,
                food.PriceFood.ToString("C").Replace(",00",""),
                namecate,
                imgFood.Image = new Bitmap(Application.StartupPath + @"\Images\Uploads\"+food.ImageFood)
                });
            }
        }
        public void LoadTable()
        {
            DataViewTable.Rows.Clear();
            List<TableFood> tables = BUS.BUS_TableFood.Instance.getTableFood();

            foreach (TableFood table in tables)
            {
                DataViewTable.Rows.Add(new object[] {
                table.Id,
                "Bàn "+table.Name
                });
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            InsertTable(txtNameTable.Text);
        }

        private void DataViewTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = DataViewTable.CurrentCell.RowIndex;
                idTable = Convert.ToInt32(DataViewTable.Rows[index].Cells[0].Value.ToString());
                txtNameTable.Text = DataViewTable.Rows[index].Cells[1].Value.ToString().Replace("Bàn ", "");
            }
            catch { }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable(idTable, txtNameTable.Text);
            LoadTable();
        }

        private void DataViewFood_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = DataViewFood.CurrentCell.RowIndex;

                idFood = Convert.ToInt32(DataViewFood.Rows[index].Cells[0].Value.ToString());
                Foods foods = BUS_Food.Instance.GetFoods(idFood);
                txtNameFood.Text = DataViewFood.Rows[index].Cells[1].Value.ToString();
                txtPrice.Text = foods.PriceFood.ToString();
                List<Category> categories = BUS_Category.Instance.GetCategories();

                cbType.Text = DataViewFood.Rows[index].Cells[3].Value.ToString();
                txtImage.Text = foods.ImageFood;

            }
            catch { }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {

                    string path = Path.Combine(@"Images\Uploads\");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    txtImage.Text = System.IO.Path.GetFileName(open.FileName);
                    path = path + System.IO.Path.GetFileName(open.FileName);
                    File.Copy(open.FileName, path);

                }
            }
            catch { }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            List<Category> categories = BUS_Category.Instance.GetCategories();
            int idCate = 0;
            foreach (Category category in categories)
            {
                if (category.Name.Equals(cbType.Text))
                {
                    idCate = category.Id;
                }

            }
            BUS_Food.Instance.InsertFood(txtNameFood.Text, idCate, int.Parse(txtPrice.Text), txtImage.Text);
            LoadFood();
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            List<Category> categories = BUS_Category.Instance.GetCategories();
            int idCate = 0;
            foreach (Category category in categories)
            {
                if (category.Name.Equals(cbType.Text))
                {
                    idCate = category.Id;
                }

            }
            BUS_Food.Instance.UpdateFood(txtNameFood.Text, idCate, int.Parse(txtPrice.Text), txtImage.Text, idFood);
            LoadFood();
        }
    }
}
