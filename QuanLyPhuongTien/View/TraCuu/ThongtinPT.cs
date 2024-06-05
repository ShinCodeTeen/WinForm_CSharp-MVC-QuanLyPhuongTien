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
    public partial class ThongtinPT : Form,getPhuongTien
    {
        public ThongtinPT()
        {
            InitializeComponent();
        }
        public MD_Phuongtien ptien;
        public void GetTT(MD_Phuongtien pt1)
        {
            this.ptien = pt1;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinPT_Load(object sender, EventArgs e)
        {
            txbBienso.Text = ptien.bienso;
            txbmabh.Text = ptien.maBH;
            txbmadk.Text = ptien.madki;
            txbmadkiem.Text = ptien.madkiem;
            txbsobb.Text = ptien.sobienban.ToString();
            txbTencsh.Text = ptien.chusohuu;
            txbtenxe.Text = ptien.tenpt;
        }
    }
}
