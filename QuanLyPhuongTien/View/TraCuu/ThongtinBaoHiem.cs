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
    public partial class ThongtinBaoHiem : Form,getBaoHiem
    {
        public ThongtinBaoHiem()
        {
            InitializeComponent();
        }
        public MD_BaoHiem bh1;
        public void GetTT(MD_BaoHiem bh)
        {
            this.bh1 = bh;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinBaoHiem_Load(object sender, EventArgs e)
        {
            txbBienSo.Text = bh1.Bienso;
            txbCCCD.Text = bh1.cccd;
            txbChush.Text = bh1.tenchuxe;
            txbHanSd.Text = bh1.hansudung;
            txbMaBh.Text = bh1.maBH;
            txbManv.Text = bh1.manv;
            txbTennv.Text = bh1.tennv;
            txbThoigian.Text = bh1.ngaydki;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
