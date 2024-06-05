using QuanLyPhuongTien.Forms.TraCuu;
using QuanLyPhuongTien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuongTien.View.TraCuu
{
    public partial class ThongtinDangKi : Form,getDangKi
    {
        public ThongtinDangKi()
        {
            InitializeComponent();
        }
        private MD_DangKi mddk;
        public void GetTT(MD_DangKi md)
        {
            this.mddk = md;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinDangKi_Load(object sender, EventArgs e)
        {
            txbBienso.Text = mddk.bienso;
            txbCCCD.Text = mddk.cccd;
            txbChusohuu.Text = mddk.tencsh;
            txbDacdiem.Text = mddk.dacdiem;
            txbLoaixe.Text = mddk.loaixe;
            txbMacb.Text = mddk.macb;   
            txbMadki.Text = mddk.madki;
            txbTenCb.Text = mddk.tencb;
            txbtenxe.Text = mddk.tenxe;
            txbThoigian.Text = mddk.thoigian;
        }
    }
}
