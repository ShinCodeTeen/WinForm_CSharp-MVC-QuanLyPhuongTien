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
    public partial class ThongtinXuPhat : Form,getXuphat
    {
        public ThongtinXuPhat()
        {
            InitializeComponent();
        }
        public MD_Xuphat getxp;
        public void GetTT(MD_Xuphat xp)
        {
            this.getxp = xp;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinXuPhat_Load(object sender, EventArgs e)
        {
            txbBienso.Text = getxp.bienso;
            txbcbpt.Text = getxp.tencb;
            txbDiaDiem.Text = getxp.diadiem;
            txbMabb.Text = getxp.maBienban;
            txbmacb.Text = getxp.macb;
            txbSotien.Text = getxp.sotien;
            txbtenNDK.Text = getxp.ten;
            txbThoiGian.Text = getxp.thoigian;
            txbVipham.Text = getxp.vipham;
        }

       
    }
}
