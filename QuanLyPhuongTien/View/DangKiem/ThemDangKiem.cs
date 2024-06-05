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
    public partial class ThemDangKiem : Form,IFormDataReceiver
    {
        public ThemDangKiem()
        {
            InitializeComponent();
        }
        public Account loginAc;
        public void ReceiveData(Account Account)
        {
            this.loginAc = Account;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string madkiem = txbmaDkiem.Text;
            string madki = txbmadki.Text;
            string bienso= txbBienso.Text;
            string chusohuu = txbTencsh.Text;
            string thoigian = DateTime.Now.ToString("dd/MM/yyyy");
            string macb = loginAc.MaCV;
            string tencb = loginAc.Name;
            try
            {
                MV_DangKiem.Instance.InsertDangKiem(madkiem, madki, thoigian, macb, tencb, bienso, chusohuu);
                MessageBox.Show("Thêm Dữ Liệu Thành Công!");
                SetMaDKiem();
                txbmadki.Text = "";
            }
            catch (Exception ex) { }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txbmadki.Text = "";
        }
        private const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string RandomString()
        {
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(characters, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            int kiemtra = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM dbo.DangKiem WHERE maDKiem='" + randomString + "'");
            if (kiemtra > 0) { return RandomString(); }
            else return randomString;
        }
        public void SetMaDKiem()
        {
            txbmaDkiem.Text = RandomString();
        }

        private void txbmadki_TextChanged(object sender, EventArgs e)
        {
            string madk = txbmadki.Text;
            MD_DangKi dk = MV_Tracuu.Instance.SearchDki(madk);
            txbLoaixe.Text = dk.loaixe;
            txbcccd.Text = dk.cccd;
            txbBienso.Text = dk.cccd;
            txbDacdiem.Text = dk.dacdiem;
            txbTencsh.Text = dk.tencsh;
            txbTenpt.Text = dk.tenxe;
        }

        private void ThemDangKiem_Load(object sender, EventArgs e)
        {
            SetMaDKiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbmaDkiem.Text=RandomString();
        }
    }
}
