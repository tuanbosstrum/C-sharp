using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        // Hàm
        public void showControl(Control control)
        {
            PMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PMain.Controls.Add(control);
        }
        // Hàm Event
        private void btnHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            btnHome.Checked = true;
            if (btnHome.Checked == true)
            {
                btnDoanhThu.Checked = false;
                btnListSanPham.Checked = false;
                btnListUser.Checked = false;
            }
            showControl(dashboard);
        }


        private void FMain_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            showControl(dashboard);
            btnHome.Checked = true;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            BillManger manger = new BillManger();
            btnDoanhThu.Checked = true;
            if (btnDoanhThu.Checked == true)
            {
                btnHome.Checked = false;
                btnListSanPham.Checked = false;
                btnListUser.Checked = false;
            }
            showControl(manger);
        }

        private void btnListSanPham_Click(object sender, EventArgs e)
        {
            Shop_Manger shop = new Shop_Manger();
            btnListSanPham.Checked = true;
            if (btnListSanPham.Checked == true)
            {
                btnDoanhThu.Checked = false;
                btnHome.Checked = false;
                btnListUser.Checked = false;
            }
            showControl(shop);
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            StaffManager staff = new StaffManager();
            btnListUser.Checked = true;
            if (btnListUser.Checked == true)
            {
                btnDoanhThu.Checked = false;
                btnHome.Checked = false;
                btnListSanPham.Checked = false;
            }
            showControl(staff);
        }
    }
}
