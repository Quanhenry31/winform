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
    public partial class GUI_Thuthu : Form
    {
        BUS_Thuthu tt = new BUS_Thuthu();
        public GUI_Thuthu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void GUI_Thuthu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tt.ThuThu();
        }


        void reser()
        {
            txtMatt.Text = "";
            txtNamett.Text = "";
            cbGioitinhtt.Text = "";
            dtpNgaysinh.Text = "";
            txtChucvu.Text = "";
            txtLienhe.Text = "";
            txtQuequan.Text = "";
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            string keyword = txtSeach.Text;
            dataGridView1.DataSource = tt.Timkiem(keyword);
            reser();
        }

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
                    tt.KetXuatWord(saveFileDialog.FileName);
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
            if (saveFileDialog.FileName != "") { 
            
                try
                {
                    tt.XuatExcel(saveFileDialog.FileName);
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
