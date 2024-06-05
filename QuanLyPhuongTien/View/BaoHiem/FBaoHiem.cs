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

namespace QuanLyPhuongTien.Forms.BaoHiem
{
    public interface getData1
    {
        void SendAc(Account account);
    }
    public partial class FBaoHiem : Form,IFormDataReceiver 
    {

        public Account LoginAccount;
        public FBaoHiem()
        {
            InitializeComponent();

            
        }
        public void ReceiveData(Account account)
        {
          LoginAccount = account;
        }
        private void FBaoHiem_Load(object sender, EventArgs e)
        {
         LoadBH();
          
        }
        private void LoadBH()
        {
            lvBaoHiem.Items.Clear();
            List<MD_BaoHiem> list = MV_BaoHiem.Instance.LoadListBH();
            foreach (MD_BaoHiem item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Bienso);
                listViewItem.SubItems.Add(item.tenchuxe);
                listViewItem.SubItems.Add(item.maBH);
                listViewItem.SubItems.Add(item.ngaydki);
                listViewItem.SubItems.Add(item.hansudung);
                lvBaoHiem.Items.Add(listViewItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btXem_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            if (miniForm is getData1)
            {
                // Ép kiểu form được chèn thành interface IFormDataReceiver
                getData1 getdat = (getData1)miniForm;
                // Gọi phương thức để truyền dữ liệu
                getdat.SendAc(LoginAccount);
            }
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelTC.Controls.Add(miniForm);
            panelTC.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            openminiForm(new ThemBaoHiem());
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        {
            lvBaoHiem.Items.Clear();
            string timkiem = txbTimkiem.Text;
            List<MD_BaoHiem> list = MV_BaoHiem.Instance.SearchListBH(timkiem);
            foreach (MD_BaoHiem item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Bienso);
                listViewItem.SubItems.Add(item.tenchuxe);
                listViewItem.SubItems.Add(item.maBH);
                listViewItem.SubItems.Add(item.ngaydki);
                listViewItem.SubItems.Add(item.hansudung);
                lvBaoHiem.Items.Add(listViewItem);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
