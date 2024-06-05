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

namespace QuanLyPhuongTien.Forms.DangKi
{
    public partial class ThemDangKi : Form,getData
    {
        public Account AccountCB;
        public ThemDangKi()
        {
            InitializeComponent();
        }
        public void SendAc(Account account)
        {
            this.AccountCB = account;
        }
        private void ThemDangKi_Load(object sender, EventArgs e)
        {
            SetMaDKi();
        }
        private const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string RandomString()
        {
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(characters, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            int kiemtra = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM dbo.DangKi WHERE maDKi='" + randomString + "'");
            if(kiemtra > 0) { return RandomString(); }
            else return randomString;
        }
        public void SetMaDKi()
        {
            txbMaDKi.Text = RandomString();
        }

     

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txbBienso.Text= string.Empty;
            txbCCCD.Text= string.Empty;
            txbDacdiem.Text= string.Empty;
            txbLoaixe.Text= string.Empty;
            txbMaDKi.Text= string.Empty;
            txbTenCSH.Text= string.Empty;
            txbTenxe.Text= string.Empty;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string madki = txbMaDKi.Text;
            string bienso = txbBienso.Text;
            string tenxe = txbTenxe.Text;
            string loaixe = txbLoaixe.Text;
            string dacdiem = txbDacdiem.Text;
            string cccd = txbCCCD.Text;
            string tencsh = txbTenCSH.Text;
            string macb = AccountCB.MaCV;
            string tencb = AccountCB.Name;
            try
            {
                MV_DangKi.Instance.InsertDangKi(madki, bienso, tenxe, loaixe, dacdiem, cccd, macb, tencb, tencsh);
                MessageBox.Show("Thêm dữ liệu thành công");
               this.Close();    
            }
            catch {
                MessageBox.Show("Erro");           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetMaDKi();
        }
    }
}
