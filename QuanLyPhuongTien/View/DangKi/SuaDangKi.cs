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
    public partial class SuaDangKi : Form,getdki
    {
        public SuaDangKi()
        {
            InitializeComponent();
        }
        public MD_DangKi mddki;
        public void getdk(MD_DangKi dk)
        {
            this.mddki = dk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string bienso = txbBienso.Text;
                string cccd = txbcccd.Text;
                string csh = txbchush.Text;
                string madki=txbMadki.Text;
                MV_DangKi.Instance.UpdateDki(bienso, cccd, csh,madki);
                MessageBox.Show("Cập nhật dữ liệu thành công !");

            }
            catch {
                MessageBox.Show("Erro!!!");
                
            }
            this.Close();
        }

        private void SuaDangKi_Load(object sender, EventArgs e)
        {
            txbBienso.Text = mddki.bienso;
            txbcccd.Text=mddki.cccd;
            txbchush.Text = mddki.tencsh;
            txbDacdiem.Text = mddki.dacdiem;
            txbLoaixe.Text= mddki.loaixe;
            txbMadki.Text= mddki.madki;
            txbTenxe.Text=mddki.tenxe;
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
