using BUS;
using DTO;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace GUI
{
    public partial class StaffManager : UserControl
    {
        public StaffManager()
        {
            InitializeComponent();
            LoadListStaff();
        }
        public void LoadListStaff()
        {
            FStaff.Rows.Clear();
            List<Staff> staffs = BUS_Staff.Instance.getListStaff();
            foreach (Staff staff in staffs)
            {
                FStaff.Rows.Add(new Object[]{
                    staff.Id,
                    staff.Fullname,
                    staff.Phone,
                    staff.Address,
                    staff.Namelevel


                });
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string namelevel = cblevel.Text;

            BUS_Staff.Instance.InsertStaff(fullname, phone, address, namelevel);

            LoadListStaff();
        }
        int id;
        private void btnSua_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string namelevel = cblevel.Text;

            BUS_Staff.Instance.UpdateStaff(fullname, phone, address, namelevel, id);

            LoadListStaff();
        }

        private void FStaff_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = FStaff.CurrentCell.RowIndex;
                id = Convert.ToInt32(FStaff.Rows[index].Cells[0].Value.ToString());
                txtFullname.Text = FStaff.Rows[index].Cells[1].Value.ToString();
                txtPhone.Text = FStaff.Rows[index].Cells[2].Value.ToString();
                txtAddress.Text = FStaff.Rows[index].Cells[3].Value.ToString();
                cblevel.Text = FStaff.Rows[index].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_Staff.Instance.DeleteStaff(id);

            LoadListStaff();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string fullname = txtTimkiem.Text;
            FindStaff(fullname);
        }
        public void FindStaff(string fullname)
        {
            FStaff.Rows.Clear();
            List<Staff> staffs = BUS_Staff.Instance.FindStaff(fullname);
            foreach (Staff staff in staffs)
            {
                FStaff.Rows.Add(new Object[]{
                    staff.Id,
                    staff.Fullname,
                    staff.Phone,
                    staff.Address,
                    staff.Namelevel


                });
            }

        }
    }
}
