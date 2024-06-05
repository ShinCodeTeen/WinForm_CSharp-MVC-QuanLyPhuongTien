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

namespace QuanLyPhuongTien.Forms.DangKi
{
    public interface getdki
    {
        void getdk(MD_DangKi dk);
    }
    public interface getData
    {
        void SendAc(Account account);
    }
   
    public partial class FDangKi : Form,IFormDataReceiver
    {
       
        public FDangKi()
        {
            InitializeComponent();
        }
        public Account LgAc;
        public void ReceiveData(Account account)
        {
            LgAc = account;
        }
      
        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            if (miniForm is getData)
            {
                // Ép kiểu form được chèn thành interface IFormDataReceiver
               getData getdat = (getData)miniForm;
                // Gọi phương thức để truyền dữ liệu
                getdat.SendAc(LgAc);
            }
            else if(miniForm is getdki) 
                {
                getdki getdk = (getdki)miniForm;
                getdk.getdk(md);
                } 
            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelHienthi.Controls.Add(miniForm);
            panelHienthi.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            openminiForm(new ThongtinDangKi());
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            openminiForm(new ThemDangKi());
         
           
        }
        public MD_DangKi md;
        private void btSua_Click(object sender, EventArgs e)
        {
            if (listviewDangki.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listviewDangki.SelectedItems[0];
                string bienso = selectedItem.SubItems[1].Text; // Lấy giá trị của cột thứ hai
                md = MV_Tracuu.Instance.SearchDki(bienso);
                openminiForm(new SuaDangKi());

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương tiện!");
            }
         
        
        }
      
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (listviewDangki.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listviewDangki.SelectedItems[0];
                string bienso = selectedItem.SubItems[1].Text; // Lấy giá trị của cột thứ hai
                md = MV_Tracuu.Instance.SearchDki(bienso);
                string madki = md.madki;
               
                
                    MV_DangKi.Instance.DeletDki(bienso, madki);
                    MessageBox.Show("Xóa dữ liệu thành công");
              
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương tiện!");
            }
            LoadDK();
        }

        private void listviewDangki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDK()
        {
            listviewDangki.Items.Clear();
            List<MD_DangKi> list = MV_DangKi.Instance.LoadDKList();
            foreach (MD_DangKi item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.bienso);
                listViewItem.SubItems.Add(item.tencsh);
                listViewItem.SubItems.Add(item.madki);
                listViewItem.SubItems.Add(item.thoigian);
                listviewDangki.Items.Add(listViewItem);
            }
        }
        private void FDangKi_Load(object sender, EventArgs e)
        {
            LoadDK();
        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        {
            listviewDangki.Items.Clear();
            string timkiem = txbTimkiem.Text;
            List<MD_DangKi> list = MV_DangKi.Instance.SearchDKList(timkiem);
            foreach (MD_DangKi item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.bienso);
                listViewItem.SubItems.Add(item.tencsh);
                listViewItem.SubItems.Add(item.madki);
                listViewItem.SubItems.Add(item.thoigian);
                listviewDangki.Items.Add(listViewItem);
            }
        }
    }

}
