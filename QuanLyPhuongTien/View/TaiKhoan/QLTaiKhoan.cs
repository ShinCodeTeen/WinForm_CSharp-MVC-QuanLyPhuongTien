using QuanLyPhuongTien.Forms;
using QuanLyPhuongTien.Model;
using QuanLyPhuongTien.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuongTien.View.TaiKhoan
{
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
           
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelTK.Controls.Add(miniForm);
            panelTK.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            openminiForm(new ThemTK());

        }
        private void LoadAC()
        {
            lvTaiKhoan.Items.Clear();
            List<Account> list =MV_Account.Instance.GetListAc();
            foreach (Account item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Username);
                listViewItem.SubItems.Add(item.Password);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.MaCV);
                lvTaiKhoan.Items.Add(listViewItem);
            }
        }
        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadAC();
        }


        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTaiKhoan.SelectedItems[0];
                string username = selectedItem.SubItems[1].Text; // Lấy giá trị của cột thứ hai
         
                MV_Account.Instance.DeletAC(username);
                MessageBox.Show("Xóa dữ liệu thành công !!");
                LoadAC();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản!!!");
            }
          
        }
    }
}
