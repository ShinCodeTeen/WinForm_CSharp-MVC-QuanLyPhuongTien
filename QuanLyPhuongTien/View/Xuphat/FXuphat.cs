using QuanLyPhuongTien.Forms.BaoHiem;
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

namespace QuanLyPhuongTien.Forms.Xuphat
{
    public partial class FXuphat : Form,IFormDataReceiver
    {
        public FXuphat()
        {
            InitializeComponent();
        }
        public Account loginAc;
        public void ReceiveData(Account Account)
        {
            this.loginAc = Account;
        }
        private void btXem_Click(object sender, EventArgs e)
        {
            listviewHT.Items.Clear();
            string timkiem = txbTimkiem.Text;
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
                listviewHT.Items.Add(item);
            }
        }
        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            if (miniForm is IFormDataReceiver)
            {
                // Ép kiểu form được chèn thành interface IFormDataReceiver
                IFormDataReceiver formDataReceiver = (IFormDataReceiver)miniForm;
                // Gọi phương thức để truyền dữ liệu
                formDataReceiver.ReceiveData(loginAc);
            }
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelHienthi.Controls.Add(miniForm);
            panelHienthi.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            openminiForm(new ThemXuphat());
        }
        private void LoadXP()
        {
            listviewHT.Items.Clear();
            List<MD_Xuphat> list = MV_Xuphat.Instance.LoadListBB();
            foreach (MD_Xuphat item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.bienso);
                listViewItem.SubItems.Add(item.ten);
                listViewItem.SubItems.Add(item.maBienban);
                listViewItem.SubItems.Add(item.thoigian);
                listviewHT.Items.Add(listViewItem);
            }
        }

        private void FXuphat_Load(object sender, EventArgs e)
        {
            LoadXP();
        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        {
            listviewHT.Items.Clear();
            string timkiem = txbTimkiem.Text;
            List<MD_Xuphat> list = MV_Xuphat.Instance.SearchListBB(timkiem);
            foreach (MD_Xuphat item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.bienso);
                listViewItem.SubItems.Add(item.ten);
                listViewItem.SubItems.Add(item.maBienban);
                listViewItem.SubItems.Add(item.thoigian);
                listviewHT.Items.Add(listViewItem);
            }
        }
    }
}
