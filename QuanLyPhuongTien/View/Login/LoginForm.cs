using QuanLyPhuongTien.Forms;
using QuanLyPhuongTien.Model;
using QuanLyPhuongTien.ModelView;
using QuanLyPhuongTien.View.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuongTien
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (Login(username, password))
            {
                Account ac = MV_Account.Instance.GetAccount(username);
                Trangchu tc = new Trangchu(ac);
               
                this.Hide();
                tc.ShowDialog();
                
            }
            else
            {
                lblER.Visible = true;
                
            }
        }
        private bool Login(string username, string password)
        {
            return MV_Account.Instance.Login(username,password);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           FDangkiTK fDangkiTK = new FDangkiTK();
            this.Hide();
            fDangkiTK.ShowDialog();
            this.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblER.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblER.Visible = false;
        }
    }
}
