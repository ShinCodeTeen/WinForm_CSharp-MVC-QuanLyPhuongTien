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
    public partial class ThemXuphat : Form,IFormDataReceiver
    {
        public ThemXuphat()
        {
            InitializeComponent();
        }
        public Account loginAc;
        public void ReceiveData(Account Account)
        {
            this.loginAc = Account;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string bienso = txbBienso.Text;
            string mabb= txbmaBB.Text;
            string nguoidieukhien = txbTenNDK.Text;
            string vipham = txbVipham.Text;
            string sotien = txbSotien.Text;
            string diadiem = txbDiaDiem.Text;
            string thoigian=txbThoigian.Text;
            string cccd = txbCccd.Text;
            string cbpt =txbtencb.Text;
            string macbpt=txbmacb.Text;
            string macbth = loginAc.MaCV;
            string tencbth = loginAc.Name;

            try
            {
                MV_Xuphat.Instance.InsertXuphat(mabb, bienso, cccd, nguoidieukhien, vipham, diadiem, thoigian, sotien, macbpt, cbpt, macbth, tencbth);
                MessageBox.Show("Thêm dữ liệu thành công");

                txbBienso.Text = string.Empty;
                txbCccd.Text = string.Empty;
                txbChusohuu.Text = string.Empty;
                txbDiaDiem.Text = string.Empty;
                setmaBB();
                txbmacb.Text = string.Empty;
                txbSotien.Text = string.Empty;
                txbtencb.Text = string.Empty;
                txbTenNDK.Text = string.Empty;
                txbVipham.Text = string.Empty;
                txbThoigian.Text = string.Empty;


            }
            catch {
                MessageBox.Show("ERRO!!!");
            }
        }
        private const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public string RandomString()
        {
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(characters, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            int kiemtra = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM dbo.BienBan WHERE maBienban='" + randomString + "'");
            if (kiemtra > 0) { return RandomString(); }
            else return randomString;
        }
        private void setmaBB()
        {
            txbmaBB.Text = RandomString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setmaBB();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txbBienso.Text = string.Empty;
            txbCccd.Text = string.Empty;
            txbChusohuu.Text = string.Empty;
            txbDiaDiem.Text = string.Empty;
            setmaBB();
            txbmacb.Text = string.Empty;
            txbSotien.Text = string.Empty;
            txbtencb.Text = string.Empty;
            txbTenNDK.Text = string.Empty;
            txbVipham.Text = string.Empty;
            txbThoigian.Text = string.Empty;
        }

        private void ThemXuphat_Load(object sender, EventArgs e)
        {
            setmaBB();
        }
    }
}
