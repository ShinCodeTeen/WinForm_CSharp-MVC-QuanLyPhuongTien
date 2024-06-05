using QuanLyPhuongTien.Forms.DangKi;
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

namespace QuanLyPhuongTien.Forms.DangKiem
{
    public partial class FDangKiem : Form,IFormDataReceiver
    {
        public FDangKiem()
        {
            InitializeComponent();
        }
        public Account LgAc;
        public void ReceiveData(Account account)
        {
            LgAc = account;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            openminiForm(new ThemDangKiem());
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
                IFormDataReceiver getdat = (IFormDataReceiver)miniForm;
                // Gọi phương thức để truyền dữ liệu
                getdat.ReceiveData(LgAc);
            }
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelDangKiem.Controls.Add(miniForm);
            panelDangKiem.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }
        private void LoadDK()
        {
            lvDangKiem.Items.Clear();
            List<MD_DangKiem> list = MV_DangKiem.Instance.LoadListDK();
            foreach (MD_DangKiem item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.bienso);
                listViewItem.SubItems.Add(item.chusohuu);
                listViewItem.SubItems.Add(item.madkiem);
                listViewItem.SubItems.Add(item.thoigian);
                lvDangKiem.Items.Add(listViewItem);
            }
        }
        private void FDangKiem_Load(object sender, EventArgs e)
        {
            LoadDK();
        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        {
            lvDangKiem.Items.Clear();
            string timkiem = txbTimkiem.Text;
            List<MD_DangKiem> list = MV_DangKiem.Instance.SearchDKiemList(timkiem);
            foreach (MD_DangKiem item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.bienso);
                listViewItem.SubItems.Add(item.chusohuu);
                listViewItem.SubItems.Add(item.madkiem);
                listViewItem.SubItems.Add(item.thoigian);
                lvDangKiem.Items.Add(listViewItem);
            }
        }
    }
}
