using MySql.Data.MySqlClient;
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

namespace QuanLyPhuongTien.Forms.BaoHiem
{
    public partial class ThemBaoHiem : Form,getData1
    {
        public ThemBaoHiem()
        {
            InitializeComponent();
        }
        public Account Account;
        public void SendAc(Account account)
        {
            this.Account = account;
        }
        private const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public string RandomString()
        {
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(characters, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            int kiemtra = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM dbo.BaoHiem WHERE maBH='" + randomString + "'");
            if (kiemtra > 0) { return RandomString(); }
            else return randomString;
        }
       
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            txbMaBH.Text = RandomString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string bienso = txbBienSo.Text;
            string cccd = txbCCCD.Text;
            string hsd = dtpkHSD.Value.ToString("dd/MM/yyyy");
            string mabh = txbMaBH.Text;
            string tencsh = txbTenCSH.Text;
            string manv = Account.MaCV;
            string tennv = Account.Name;
            string ngaydk = DateTime.Now.Date.ToString("dd/MM/yyyy");
            try
            {
                MV_BaoHiem.Instance.InsertBaoHiem(mabh,bienso,cccd,tencsh,ngaydk,hsd,manv,tennv);
                MessageBox.Show("Thêm Dữ Liệu Thành Công!!!");
                this.Close();
               
            }
            catch
            {
                MessageBox.Show("ERRO!!!");
            }
        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            string bienso = txbBienSo.Text;
            MD_DangKi dk = MV_Tracuu.Instance.SearchDki(bienso);
            txbCCCD.Text = dk.cccd;
            txbTenCSH.Text = dk.tencsh;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txbTenCSH.Text =string.Empty;
            txbMaBH.Text = RandomString();
            txbCCCD.Text = string.Empty;
            txbBienSo.Text=string.Empty;
            dtpkHSD.Value=default;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemBaoHiem_Load(object sender, EventArgs e)
        {
            txbMaBH.Text = RandomString();
        }
    }
}
