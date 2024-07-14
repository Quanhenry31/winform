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
    public partial class GUI_Viewtt : Form
    {
        BUS_Thuthu tt = new BUS_Thuthu();
        public GUI_Viewtt()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Matt = txtMatt.Text;
            string Ten = txtNamett.Text;
            string gioiTinh = cbGioitinhtt.Text;
            DateTime Ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
            string Chucvu = txtChucvu.Text;
            string Lienhe = txtLienhe.Text;
            string qq = txtQuequan.Text;
            try
            {
                if(MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Thuthu thut = new Thuthu(Matt, Ten, gioiTinh, Ngaysinh, Chucvu, Lienhe, qq);
                    tt.addThuTHu(thut);
                    GUI_Viewtt_Load(sender, e);
                    MessageBox.Show("Thêm thành công!");
                }
            
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                GUI_Viewtt_Load(sender, e);
            }
        }

        private void GUI_Viewtt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tt.ThuThu(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Matt = txtMatt.Text;
            string Ten = txtNamett.Text;
            string gioiTinh = cbGioitinhtt.Text;
            DateTime Ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
            string Chucvu = txtChucvu.Text;
            string Lienhe = txtLienhe.Text;
            string qq = txtQuequan.Text;
            try
            {
                if(MessageBox.Show("Bạn có muốn sửa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Thuthu thut = new Thuthu(Matt, Ten, gioiTinh, Ngaysinh, Chucvu, Lienhe, qq);
                    tt.suaThuThu(thut);
                    GUI_Viewtt_Load(sender, e);
                    MessageBox.Show("Sửa thành công!");

                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                GUI_Viewtt_Load(sender, e);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Matt = txtMatt.Text;
                    tt.xoaThuThu(Matt);
                    GUI_Viewtt_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Xóa chưa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Viewtt_Load(sender, e);
            }
        }
           

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNamett.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbGioitinhtt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpNgaysinh.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()).ToShortDateString();
            txtChucvu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtLienhe.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtQuequan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnKetxuat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        void reset()
        {
            txtMatt.Text = "";
            txtNamett.Text = "";
            cbGioitinhtt.Text = "";
            dtpNgaysinh.Text = "";
            txtChucvu.Text = "";
            txtLienhe.Text = "";
            txtQuequan.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSeach.Text;
            dataGridView1.DataSource = tt.Timkiem(keyword);
            reset();
        }
    }
}
