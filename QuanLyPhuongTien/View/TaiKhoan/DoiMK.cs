using QuanLyPhuongTien.Forms;
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

namespace QuanLyPhuongTien.View.TaiKhoan
{
    public partial class DoiMK : Form,IFormDataReceiver
    {
        public DoiMK()
        {
            InitializeComponent();
        }
        public Account ac;
        public void ReceiveData(Account account)
        {
            this.ac = account;
        }
        private void DoiMK_Load(object sender, EventArgs e)
        {
            txbTaiKhoan.Text = ac.Username;
            lbER.Visible = false;
            txbmatkhaumoi.Enabled = false;
            txbxacnhan.Enabled = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (txbMatkhau.Text == ac.Password)
            {
                txbmatkhaumoi.Enabled=true;
                txbxacnhan.Enabled=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txbmatkhaumoi.Text==txbxacnhan.Text)
            {
                try
                {
                    MV_Account.Instance.UpdateAC(ac.Username, txbmatkhaumoi.Text);
                    MessageBox.Show("Cập nhật dữ liệu thành công!!");

                }
                catch {

                    MessageBox.Show("ERRO!!!");
                }
            }
            else
            {
                lbER.Visible = true;
            }
        }

        private void txbmatkhaumoi_TextChanged(object sender, EventArgs e)
        {
            lbER.Visible=false;
        }

        private void txbxacnhan_TextChanged(object sender, EventArgs e)
        {
            lbER.Visible = false;
        }
    }
}
