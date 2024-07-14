using BUS;
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
    public partial class GUI_Book : Form
    {
        public GUI_Book()
        {
            InitializeComponent();
        }
        BUS_Dausach ds = new BUS_Dausach();
        private void GUI_Addbook_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetDausach();
            dataGridView2.DataSource = ds.Soluongsach();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSeach.Text;
            dataGridView1.DataSource = ds.Timkiem(keyword);
            reset();
        }

        void reset()
        {
            txtmaDS.Text = "";
            txtTensach.Text = "";
            dtpNamxuatban.Text = "";
            dtpNgaynhap.Text = "";
            txtGia.Text = "";
            txtSoluong.Text = "";
            txtLinhvuc.Text = "";
            txtNhaxb.Text = "";
            txtTacgia.Text = "";
            txtTinhtrang.Text = "";
        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtmaDS.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTensach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtpNamxuatban.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            dtpNgaynhap.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            txtGia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtLinhvuc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtNhaxb.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtTacgia.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtTinhtrang.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnKetxuat_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin sách";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    ds.KetXuatWord(saveFileDialog.FileName);
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
                    ds.XuatExcel(saveFileDialog.FileName);
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
