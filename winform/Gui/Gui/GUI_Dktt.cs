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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class GUI_Dktt : Form
    {
        BUS_Dangkitk dk = new BUS_Dangkitk();
        BUS_Taikhoan TK = new BUS_Taikhoan();
        public GUI_Dktt()
        {
            InitializeComponent();
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
            txtMatma.Text = "";
            cbPhanquyentt.Text = "";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaikhoan.Text;
            string matkhau = txtMatkhau.Text;
            string email = txtEmail.Text;
            string matma = txtMatma.Text;
            string phanquyen = cbPhanquyentt.Text;
            try
            {
            if(matma == "1")
            {
                Taikhoan AB = new Taikhoan(taikhoan, matkhau, email, phanquyen, matma);
                dk.themTaikhoan(AB);
                GUI_Dktt_Load(sender, e);
                MessageBox.Show("Đăng kí thành công!");
            }

            }
            catch
            {

                MessageBox.Show("Đăng kí không thành công!");
            }
            finally
            {
                GUI_Dktt_Load(sender, e);
            }
        }

        private void GUI_Dktt_Load(object sender, EventArgs e)
        {

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
            string matma = txtMatma.Text;
            string phanquyen = cbPhanquyentt.Text;


            try
            {
            if (KiemTraTk(taikhoan, email))
            {
                string v = txtMatkhau.Text;
                string mm = txtMatma.Text;

                if (v != "Mật khẩu" && v != "" && v != null && mm == "1")
                {
                    Taikhoan AB = new Taikhoan(taikhoan, matkhau, email, phanquyen, matma);
                    dk.Doi_mk(AB);
                    GUI_Dktt_Load(sender, e);
                    MessageBox.Show("Đổi mật khẩu thành công!");

                }
                else
                {
                    MessageBox.Show("Hãy xem lại mật khẩu!");
                }
            }
            }
            catch
            {                
                MessageBox.Show("Hãy xem lại tài khoản và email!");
            }
            finally
            {
                GUI_Dktt_Load( sender,  e);
            }

            
          
        }
    }
}
