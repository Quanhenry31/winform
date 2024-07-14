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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gui
{
    public partial class GUI_Viewdg : Form
    {
        BUS_Docgia docgia = new BUS_Docgia();
        public GUI_Viewdg()
        {
            InitializeComponent();
        }

       

        private void GUI_Viewdg_Load(object sender, EventArgs e)
        {
            cbMalop.DataSource = docgia.GetLop();
            cbMalop.ValueMember = "Malop";
            cbMakhoa.DataSource = docgia.Getkhoa();
            cbMakhoa.ValueMember = "Makhoa";
            DataTable dt = docgia.GetDocgiaby_username(GUI_Login.username);
            foreach(DataRow dr in dt.Rows)
            {
                txtSothe.Text = dr["Sothe"].ToString();
                txtName.Text = dr["Hoten"].ToString();
                txtNgaysinh.Text = dr["NgaySinh"].ToString();
                cbMalop.Text = dr["Malop"].ToString();
                cbSex.Text = dr["Gioitinh"].ToString();
                cbMakhoa.Text = dr["Makhoa"].ToString();
                txtLienhe.Text = dr["Lienhe"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtQuequan.Text = dr["Quequan"].ToString();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Sothe = txtSothe.Text;
            string Hotendg = txtName.Text;
            DateTime ngaySinhdg = DateTime.Parse(txtNgaysinh.Text);
            string Malop = cbMalop.Text;
            string Gioitinhdg = cbSex.Text;
            string makhoa = cbMakhoa.Text;
            string Lienhedg = txtLienhe.Text;
            string Emaildg = txtEmail.Text;
            string Quequandg = txtQuequan.Text;
            string username = GUI_Login.username;
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Docgia dg = new Docgia(Sothe, Hotendg, ngaySinhdg, Gioitinhdg, Lienhedg, Emaildg, Quequandg, Malop, makhoa , username);
                    docgia.updateDocGia(dg);
                    GUI_Viewdg_Load(sender, e);
                    MessageBox.Show("Cập nhập thành công!");
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Cập nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Viewdg_Load(sender, e);
            }

         
        }
        
        //oke


        private void btnKetxuat_Click(object sender, EventArgs e)
        {
           

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Microsoft Word | *.docx";
                saveFileDialog.Title = "Lưu thông tin độc giả";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        docgia.KetXuatWord(saveFileDialog.FileName);
                        MessageBox.Show("Kết xuất thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo lỗi");
                    }

                }


            
        }


        //oke

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }




        void reset()
        {
            txtSothe.Text = "";
            txtName.Text = "";
            txtNgaysinh.Text = "";
            cbSex.Text = "";
            txtLienhe.Text = "";
            txtEmail.Text = "";
            txtQuequan.Text = "";
            cbMakhoa.Text = "";
            cbMalop.Text = "";
        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Lưu thông tin khách hàng";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    docgia.XuatExcel(saveFileDialog.FileName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi");
                }
            }
        }


    }
}
