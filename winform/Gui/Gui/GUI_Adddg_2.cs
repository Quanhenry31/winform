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
    public partial class GUI_Adddg_2 : Form
    {
        BUS_Docgia docgia = new BUS_Docgia();
        public GUI_Adddg_2()
        {
            InitializeComponent();
        }

        private void GUI_Adddg_2_Load(object sender, EventArgs e)
        {
            DataTable dt = docgia.GetDocgiaby_username_dg(GUI_Dkdg.username);
            cbMalop.DataSource = docgia.GetLop();
            cbMalop.ValueMember = "Malop";
            cbMakhoa.DataSource = docgia.Getkhoa();
            cbMakhoa.ValueMember = "Makhoa";
            foreach (DataRow dr in dt.Rows)
            {
                txtUser.Text = dr["Username"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Sothe = txtSothe.Text;
            string Hoten = txtName.Text;
            DateTime ngaySinh = DateTime.Parse(txtNgaysinh.Text);
            string Malop = cbMalop.Text;
            string gioiTinh = cbGioitinh.Text;
            string quequan = txtQuequan.Text;
            string makhoa = cbMakhoa.Text;
            string Lienhe = txtLienhe.Text;
            string Email = txtEmail.Text;
            string username = txtUser.Text;

            try
            {
                if (MessageBox.Show("Bạn có muốn thêm độc giả này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Docgia dg = new Docgia(Sothe, Hoten, ngaySinh, gioiTinh, Lienhe, Email, quequan, Malop, makhoa , username);
                    docgia.addDocGia(dg);
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Adddg_2_Load(sender, e);
            }
        }
    }
}
