using QuanLyPhuongTien.Forms;
using QuanLyPhuongTien.Forms.TraCuu;
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

namespace QuanLyPhuongTien.View.TraCuu
{
    public interface getPhuongTien
    {
        void GetTT(MD_Phuongtien pt);
    }
    public partial class PhuongTien : Form
    {
        public PhuongTien()
        {
            InitializeComponent();
        }
        public MD_Phuongtien pt=null;
        private void btXem_Click(object sender, EventArgs e)
        {
            if (lvPhuongTien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPhuongTien.SelectedItems[0];
                string bienso = selectedItem.SubItems[1].Text; // Lấy giá trị của cột thứ hai
                pt = MV_Tracuu.Instance.SearchPhuongTien(bienso);
                openminiForm(new ThongtinPT());

            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            lvPhuongTien.Items.Clear();
            string timkiem = txbTimKiem.Text;
            MD_Phuongtien pt = MV_Tracuu.Instance.SearchPhuongTien(timkiem);
            if (pt == null)
            {
                MessageBox.Show("Khong Tim Thay!!!");
            }
            else
            {
                ListViewItem item = new ListViewItem(pt.Id.ToString());
                item.SubItems.Add(pt.bienso);
                item.SubItems.Add(pt.tenpt);
                item.SubItems.Add(pt.chusohuu);

                lvPhuongTien.Items.Add(item);
            }
        }
        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            //thua ke lai getphuongtien
            if (miniForm is getPhuongTien)
            {
                // Ép kiểu form được chèn thành interface
                getPhuongTien formDataReceiver = (getPhuongTien)miniForm;
                // Gọi phương thức để truyền dữ liệu
                formDataReceiver.GetTT(pt);
            }
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelHienThi.Controls.Add(miniForm);
            panelHienThi.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

        private void lvPhuongTien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
