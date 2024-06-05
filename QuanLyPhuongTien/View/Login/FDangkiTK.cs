using QuanLyPhuongTien.ModelView;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuongTien.View.Login
{
    public partial class FDangkiTK : Form
    {
        public FDangkiTK()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangKi_Click(object sender, EventArgs e)
        {
            if(Kiemtra())
            {
                string name = txbName.Text;
                string username= txbUsername.Text;
                string password = txbPassword.Text;
                string CCCD=txbCCCD.Text;
                string maCV = "CD" + CCCD;
                string diachi = txbAddress.Text;
                string chucvu = "Công dân";
                MV_Account.Instance.CreateAccount(username,password,name,chucvu,0,diachi,maCV);
                MessageBox.Show("Tạo tài khoản thành công!");
                this.Close();
            }
            else { lblER.Visible = true; }

        }
        public bool Kiemtra()
        {
            if(txbName.Text.IsEmpty()||txbUsername.Text.IsEmpty()||txbPassword.Text.IsEmpty()||txbCCCD.Text.IsEmpty()) {
               
                return false;
            }
            else
            { return true; }
        }
    }
}
