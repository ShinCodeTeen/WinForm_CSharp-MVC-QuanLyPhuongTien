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
    public partial class ThemTK : Form
    {
        public ThemTK()
        {
            InitializeComponent();
        }

        private void ThemTK_Load(object sender, EventArgs e)
        {
            loadCbb();
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string username = txbTaiKhoan.Text;
            string password = txbMatkhau.Text;
            string ten =txbTen.Text;
            string macv=txbMaCV.Text;
            PhanQuyen pq = (PhanQuyen)cbbPhanquyen.SelectedItem;
            string chucvu=pq.chucvu;
            string diachi=txbDiachi.Text;
            int type = pq.type;
            try
            {
                MV_Account.Instance.CreateAccount(username, password, ten, macv, type, diachi, macv);
                MessageBox.Show("Thêm Dữ Liệu Thành Công!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ERRO!!!");
            }
        }
        public void loadCbb()
        {
            List<PhanQuyen> list = MV_Account.Instance.GetPhanquyen();
            cbbPhanquyen.DataSource = list;
            cbbPhanquyen.DisplayMember = "chucvu";
        }

        private void btReset_Click(object sender, EventArgs e)
        {
           
            txbDiachi.Text = string.Empty;
            txbMaCV.Text = string.Empty;
            txbMatkhau.Text = string.Empty;
            txbTaiKhoan.Text = string.Empty;
            txbTen.Text = string.Empty;

        }

        private void ThemTK_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
