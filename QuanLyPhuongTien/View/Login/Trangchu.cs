using QuanLyPhuongTien.Forms.BaoHiem;
using QuanLyPhuongTien.Forms.DangKi;
using QuanLyPhuongTien.Forms.DangKiem;
using QuanLyPhuongTien.Forms.TraCuu;
using QuanLyPhuongTien.Forms.Xuphat;
using QuanLyPhuongTien.Model;
using QuanLyPhuongTien.View.TaiKhoan;
using QuanLyPhuongTien.View.TraCuu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuongTien.Forms
{
    public interface IFormDataReceiver
    {
        void ReceiveData(Account account);
    }
    public partial class Trangchu : Form
    {
        public Account LoginAccount { get; set; }
        public Trangchu(Account LoginAc)
        {
          
            InitializeComponent();

            this.LoginAccount = LoginAc;
            ChangeAccount(LoginAccount);

            CustemizeDesing();
        }
        public void ReceiveData(Account Account)
        {
            this.LoginAccount = Account;
        }
        void ChangeAccount(Account acc)
        {
           lblTen.Text = acc.Name;
            lblChucvu.Text = acc.Chucvu;
            if(acc.Type == 0)
            {
                btDKvaXP.Visible = false;
                btBHvaDK.Visible = false;
                btQLTK.Visible = false;
            }
            else if(acc.Type == 2) {
            btBHvaDK.Visible=false;
                btQLTK.Visible = false;
            }
            else if(acc.Type == 3)
            {
                btDKvaXP.Visible =false;
                btBaoHiem.Visible = false;
                btQLTK.Visible = false;
            }
            else if(acc.Type == 4)
            {
                btDKvaXP.Visible=false;
                btDangKiem.Visible = false;
                btQLTK.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSbubMenu(panelTracuu);
        }

       
        private void CustemizeDesing()
        {
            panelTracuu.Visible = false;
            panelDKvaXP.Visible = false;
            panelBaoHiem.Visible = false;
            panelTaikhoan.Visible = false;  
            
        }
        private void HideSubMenu()
        {
            if(panelBaoHiem.Visible==true) {
                panelBaoHiem.Visible = false;
            }
           
            if (panelDKvaXP.Visible == true)
            {
                panelDKvaXP.Visible = false;    
            }
            if(panelTracuu.Visible == true)
            {
                panelTracuu.Visible = false;
            }
            if(panelTaikhoan.Visible == true)
            { panelTaikhoan.Visible = false; }
        }
        private void ShowSbubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btTracuuDK_Click(object sender, EventArgs e)
        {
            openminiForm(new TCDangki());
            //Code
            //...

            HideSubMenu();
        }

        private void btTracuuBH_Click(object sender, EventArgs e)
        {
            openminiForm(new TCBaohiem());
            //code
            //..

            HideSubMenu();
        }

        private void btTracuuXP_Click(object sender, EventArgs e)
        {
            openminiForm(new TCXuphat());   
            //code
            //...
            HideSubMenu();

        }

        private void btDangKi_Click(object sender, EventArgs e)
        {
            openminiForm(new FDangKi());
            //code
            //...
            HideSubMenu();
        }

        private void btXuPhat_Click(object sender, EventArgs e)
        {
            openminiForm(new FXuphat());
            //code
            //...
            HideSubMenu();
        }



        private void btDKvaXP_Click(object sender, EventArgs e)
        {
            ShowSbubMenu(panelDKvaXP);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowSbubMenu(panelBaoHiem);
           
        }
        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowSbubMenu(panelTaikhoan);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            openminiForm(new FBaoHiem());
            HideSubMenu();
        }

        private void btDangKiem_Click(object sender, EventArgs e)
        {
            openminiForm(new FDangKiem());
            HideSubMenu();
        }

        private Form activeForm = null;
        private void openminiForm(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = miniForm;
            if (miniForm is IFormDataReceiver)
            {
                // Ép kiểu form được chèn thành interface IFormDataReceiver
                IFormDataReceiver formDataReceiver = (IFormDataReceiver)miniForm;
                // Gọi phương thức để truyền dữ liệu
                formDataReceiver.ReceiveData(LoginAccount);
            }

            miniForm.TopLevel = false;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(miniForm);
            panelDesktop.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBtExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát!", "EXIT", MessageBoxButtons.OKCancel);

        
            if (result == DialogResult.OK)
            {

                Application.Exit();
            }
       
            else if (result == DialogResult.Cancel)
            {
             
            }
            
           
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();// đóng form
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btTraCuuPT_Click(object sender, EventArgs e)
        {
            openminiForm(new PhuongTien());
        }

        private void btQLTK_Click(object sender, EventArgs e)
        {
            openminiForm(new QLTaiKhoan());
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            openminiForm(new DoiMK());
        }
    }
}
