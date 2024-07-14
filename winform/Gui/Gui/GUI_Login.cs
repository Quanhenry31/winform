using BUS;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }
        BUS_Taikhoan tK = new BUS_Taikhoan();
        public static string username;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

       

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool KiemTraTk(string taikhoan, string matkhau, string Phanquyen)
        {
            return tK.GetTaikhoan(taikhoan, matkhau, Phanquyen).Rows.Count > 0;
        }

      

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tk = txtUserName.Text;
            string mk = txtPass.Text;
            string pq = cboPhanquyen.Text ;
            username = tk;

              if (tk != "Tài Khoản" || mk != "Mật Khẩu" || pq != "Loại tài khoản?")
             {
                if(cboPhanquyen.SelectedIndex == 0)
                {
                    if(KiemTraTk(tk, mk, pq))
                    {
                        GUI_Maintt maintt = new GUI_Maintt();
                        maintt.Show();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Hãy xem lại tài khoản và mật khẩu!");
                    }
                    
                }
                else if(cboPhanquyen.SelectedIndex == 1)
                {
                    if (KiemTraTk(tk, mk, pq))
                    {
                        GUI_Maindg maintt = new GUI_Maindg();
                        maintt.Show();
                        reset();

                    }
                    else
                    {
                        MessageBox.Show("Hãy xem lại tài khoản và mật khẩu!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tài khoản và mật khẩu và phân quyền chính xác!");
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tài Khoản")
            {


                txtUserName.Text = "";
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mật Khẩu")
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = "";
            }
        }
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Tài Khoản";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Mật Khẩu";
                txtPass.UseSystemPasswordChar = false;
            }
        }
       
        private void btnDangky_Click(object sender, EventArgs e)
        {
            string pq = cboPhanquyen.Text;
            
            if (pq != "Loại tài khoản?")
            {
                if(cboPhanquyen.SelectedIndex == 0)
                {
                   
                        if(pq == "Thủ thư")
                        {
                            GUI_Dktt dktt = new GUI_Dktt();
                            dktt.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Chọn lại loại tài khoản!");
                        }                    
                    
                }
                if (cboPhanquyen.SelectedIndex == 1)
                {
                    
                        if (pq == "Độc giả")
                        {
                            GUI_Dkdg dkdg = new GUI_Dkdg();
                            dkdg.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Chọn lại loại tài khoản!");
                        }
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phân quyền!");
            }
                    
        }

        private void label1_Click(object sender, EventArgs e)
        {

                if (cboPhanquyen.SelectedIndex == 0)
                {
                        GUI_Dktt maintt = new GUI_Dktt();
                        maintt.Show();
                }
                 else if(cboPhanquyen.SelectedIndex == 1)
                {
                        GUI_Dkdg maintt = new GUI_Dkdg();
                         maintt.Show();
                }
            else
            {
                MessageBox.Show("Hãy chọn phân quyền!", "Thông báo");
            }
            
        }
        void reset()
        {
            txtUserName.Text = "";
            txtPass.Text = "";
        }

        private void picFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100010934737654");
        }

        private void picInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/quanba33/");
        }

        private void picYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCE3tHOnZcg-ZTJeK5AqZOxQ");
        }

    
    }
}
