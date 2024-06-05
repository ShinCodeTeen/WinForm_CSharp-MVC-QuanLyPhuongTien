using QuanLyPhuongTien.Model;
using QuanLyPhuongTien.ModelView;
using QuanLyPhuongTien.View.TraCuu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuongTien.Forms.TraCuu
{
    public interface getXuphat
    {
        void GetTT(MD_Xuphat xp);
    }
    public partial class TCXuphat : Form
    {
        public TCXuphat()
        {
            InitializeComponent();
        }


        public MD_Xuphat xp = null;
        private void btXem_Click(object sender, EventArgs e)
        {
            if (lvXuPhat.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvXuPhat.SelectedItems[0];
                string bienso = selectedItem.SubItems[1].Text; // Lấy giá trị của cột thứ hai
                xp = MV_Tracuu.Instance.SearchXuPhat(bienso);
                openminiForm(new ThongtinXuPhat());

            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            lvXuPhat.Items.Clear();
            string timkiem = txbTimKiem.Text;
            MD_Xuphat xp = MV_Tracuu.Instance.SearchXuPhat(timkiem);
            if (xp == null)
            {
                MessageBox.Show("Khong Tim Thay!!!");
            }
            else
            {
                ListViewItem item = new ListViewItem(xp.Id.ToString());
                item.SubItems.Add(xp.bienso);
                item.SubItems.Add(xp.ten);
                item.SubItems.Add(xp.maBienban);
                item.SubItems.Add(xp.thoigian);
                lvXuPhat.Items.Add(item);
            }
        } 
        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            if (miniForm is getXuphat)
            {
                // Ép kiểu form được chèn thành interface
                getXuphat formDataReceiver = (getXuphat)miniForm;
                // Gọi phương thức để truyền dữ liệu
                formDataReceiver.GetTT(xp);
            }
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelHienthi.Controls.Add(miniForm);
            panelHienthi.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

    }
}

