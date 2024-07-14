using BUS;
using DLL;
using DTO;
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
    public partial class GUI_Dkdg : Form
    {
        BUS_Dangkitk dk = new BUS_Dangkitk();
        BUS_Taikhoan TK = new BUS_Taikhoan();
        public GUI_Dkdg()
        {
            InitializeComponent();
        }
        public static string username;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaikhoan.Text;
            string matkhau = txtMatkhau.Text;
            string email = txtEmail.Text;
            string matma = " ";
            string phanquyen = cbPhanquyen.Text;
            username = taikhoan;
            if (matma == " ")
            {
                Taikhoan AB = new Taikhoan(taikhoan, matkhau, email, phanquyen, matma);
                dk.themTaikhoan(AB);
                GUI_Dkdg_Load(sender, e);
                MessageBox.Show("Đăng kí thành công!");
                GUI_Adddg_2 dg = new GUI_Adddg_2();
                dg.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng kí không thành công!");
            }
        }


        private void GUI_Dkdg_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtEmail.Text = "";
            cbPhanquyen.Text = "";
        }

        bool KiemTraTk(string taikhoan, string email)
        {
            return TK.Getdoimk(taikhoan, email).Rows.Count > 0;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaikhoan.Text;
            string email = txtEmail.Text;
            string matkhau = txtMatkhau.Text;
            string phanquyen = cbPhanquyen.Text;
            string Matma = "";

            try
            {
                if (KiemTraTk(taikhoan, email))
                {
                    string v = txtMatkhau.Text;

                    if (v != "Mật khẩu" && v != "" && v != null)
                    {
                        Taikhoan AB = new Taikhoan(taikhoan, matkhau, email, phanquyen, Matma);
                        dk.Doi_mk(AB);
                        GUI_Dkdg_Load(sender, e);
                        MessageBox.Show("Đổi mật khẩu thành công!");

                    }
                    else
                    {
                        MessageBox.Show("Hãy xem lại mật khẩu!");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy xem lại tài khoản và email");
                }
            }
            catch
            {
                MessageBox.Show("Hãy xem lại tài khoản và email!");
            }
            finally
            {
                        GUI_Dkdg_Load(sender, e);

            }
        }
    }
}
