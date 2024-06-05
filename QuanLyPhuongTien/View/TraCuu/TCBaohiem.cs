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
    public interface getBaoHiem
    {
        void GetTT(MD_BaoHiem bh);
    }
    public partial class TCBaohiem : Form
    {
        public TCBaohiem()
        {
            InitializeComponent();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (lvBaoHiem.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvBaoHiem.SelectedItems[0];
                string bienso = selectedItem.SubItems[1].Text; // Lấy giá trị của cột thứ hai
                bh1 = MV_Tracuu.Instance.SearchBaoHiem(bienso);
                openminiForm(new ThongtinBaoHiem());

            }


        }


        private void btTimKiem_Click(object sender, EventArgs e)
        {
            lvBaoHiem.Items.Clear();
            string timkiem = txbTimKiem.Text;
            MD_BaoHiem bh = MV_Tracuu.Instance.SearchBaoHiem(timkiem);
            if (bh == null)
            {
                MessageBox.Show("Khong Tim Thay!!!");
            }
            else
            {
                ListViewItem item = new ListViewItem(bh.Id.ToString());
                item.SubItems.Add(bh.Bienso);
                item.SubItems.Add(bh.tenchuxe);
                item.SubItems.Add(bh.maBH);
                item.SubItems.Add(bh.ngaydki);
                item.SubItems.Add(bh.hansudung);
                lvBaoHiem.Items.Add(item);
            }
        }
        public MD_BaoHiem bh1 = null;

        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            if (miniForm is getBaoHiem)
            {
                // Ép kiểu form được chèn thành interface IFormDataReceiver
                getBaoHiem formDataReceiver = (getBaoHiem)miniForm;
                // Gọi phương thức để truyền dữ liệu
                formDataReceiver.GetTT(bh1);
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
