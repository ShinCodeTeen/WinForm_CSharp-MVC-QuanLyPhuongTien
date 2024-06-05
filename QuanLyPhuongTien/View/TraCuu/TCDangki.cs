using QuanLyPhuongTien.Forms.BaoHiem;
using QuanLyPhuongTien.Forms.DangKi;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLyPhuongTien.Forms.TraCuu
{
    public interface getDangKi
    {
        void GetTT(MD_DangKi dk);
    }
    public partial class TCDangki : Form
    {
        public TCDangki()
        {
            InitializeComponent();
        }

  
     
        private MD_DangKi md = new MD_DangKi();
        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            if (miniForm is getDangKi)
            {
                // Ép kiểu form được chèn thành interface IFormDataReceiver
                getDangKi formDataReceiver = (getDangKi)miniForm;
                // Gọi phương thức để truyền dữ liệu
                formDataReceiver.GetTT(md);
            }
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelTCDangKi.Controls.Add(miniForm);
            panelTCDangKi.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

        private void TCDangki_Load(object sender, EventArgs e)
        {

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            listViewTCDangKi.Items.Clear();
            string timkiem = txbTimKiem.Text;
            MD_DangKi dk = MV_Tracuu.Instance.SearchDki(timkiem);
            if (dk == null)
            {
                MessageBox.Show("Khong Tim Thay!!!");
            }
            else
            {
                ListViewItem item = new ListViewItem(dk.Id.ToString());
                item.SubItems.Add(dk.bienso);
                item.SubItems.Add(dk.tencsh);
                item.SubItems.Add(dk.madki);
                item.SubItems.Add(dk.thoigian);
                listViewTCDangKi.Items.Add(item);
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (listViewTCDangKi.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTCDangKi.SelectedItems[0];
                string bienso = selectedItem.SubItems[1].Text; // Lấy giá trị của cột thứ hai
                md = MV_Tracuu.Instance.SearchDki(bienso);
                openminiForm(new ThongtinDangKi());

            }
           
        }
    }
}
