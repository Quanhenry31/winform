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
using System.Xml.Linq;

namespace Gui
{
    public partial class GUI_Adddg : Form
    {
        BUS_Docgia docgia = new BUS_Docgia();
        public GUI_Adddg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa độc giả này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Sothe = txtSothe.Text;
                    docgia.deleteDocGia(Sothe);
                    GUI_Adddg_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Xóa chưa thành công!");
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
            string user = txtUser.Text;

            try
            {
                if (MessageBox.Show("Bạn có muốn thêm độc giả này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Docgia dg = new Docgia(Sothe, Hoten, ngaySinh, gioiTinh, Lienhe, Email, quequan, Malop, makhoa, user);
                    docgia.addDocGia(dg);
                    GUI_Adddg_Load(sender, e);
                    MessageBox.Show("Thêm thành công!");
                    reset();

                }
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Adddg_Load(sender, e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSothe.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNgaysinh.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()).ToShortDateString();
            cbGioitinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtLienhe.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtQuequan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbMalop.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbMakhoa.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            string user = txtUser.Text;

            try
            {
                if (MessageBox.Show("Bạn có muốn sửa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Docgia dg = new Docgia(Sothe, Hoten, ngaySinh, gioiTinh, Lienhe, Email, quequan, Malop, makhoa, user);
                    docgia.updateDocGia(dg);
                    GUI_Adddg_Load(sender, e);
                    MessageBox.Show("sửa thành công!");
                    reset();

                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Adddg_Load(sender, e);
            }

        }


        void reset()
        {
            txtSothe.Text = "";
            txtName.Text = "";
            txtNgaysinh.Text = "";
            cbGioitinh.Text = "";
            txtLienhe.Text = "";
            txtEmail.Text = "";
            txtQuequan.Text = "";
            txtQuequan.Text = "";
            cbMalop.Text = "";
            cbMakhoa.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSeach.Text;
            dataGridView1.DataSource = docgia.Timkiem(keyword);
            reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_Adddg_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = docgia.GetDocgia();
            cbMalop.DataSource = docgia.GetLop();
            cbMalop.ValueMember = "Malop";
            cbMakhoa.DataSource = docgia.Getkhoa();
            cbMakhoa.ValueMember = "Makhoa";
        }

        private void btnWord_Click(object sender, EventArgs e)
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
