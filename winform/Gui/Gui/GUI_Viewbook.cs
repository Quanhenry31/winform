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
using DTO;



namespace Gui
{
    public partial class GUI_Viewbook : Form
    {
        BUS_Dausach ds = new BUS_Dausach();
        public GUI_Viewbook()
        {
            InitializeComponent();

        }

     

        private void GUI_Viewbook_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetDausach();
            dataGridView2.DataSource = ds.Soluongsach();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string maDS = txtmaDS.Text;
            string tenSach = txtTensach.Text;
            DateTime namXb = DateTime.Parse(dtpNamxuatban.Text);
            DateTime ngayNhap = DateTime.Parse(dtpNgaynhap.Text);
            string gia = txtGia.Text;
            int soLuong = int.Parse(txtSoluong.Text);
            string nhaXB = txtNhaxb.Text;
            string linhVuc = txtLinhvuc.Text;
            string tacGia = txtTacgia.Text;
            string tinhTrang = txtTinhtrang.Text;

            try
            {
                if (MessageBox.Show("Bạn có muốn thêm sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Dausach Sach = new Dausach(maDS, tenSach, namXb, ngayNhap, gia, soLuong, linhVuc , nhaXB, tacGia, tinhTrang);
                    ds.addDauSach(Sach);
                    GUI_Viewbook_Load(sender, e);
                    MessageBox.Show("Thêm thành công!");
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Thêm sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Viewbook_Load(sender, e);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maDS = txtmaDS.Text;
            string tenSach = txtTensach.Text;
            DateTime namXb = DateTime.Parse(dtpNamxuatban.Text);
            DateTime ngayNhap = DateTime.Parse(dtpNgaynhap.Text);
            string gia = txtGia.Text;
            int soLuong = int.Parse(txtSoluong.Text);
            string nhaXB = txtNhaxb.Text;
            string linhVuc = txtLinhvuc.Text;
            string tacGia = txtTacgia.Text;
            string tinhTrang = txtTinhtrang.Text;
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Dausach Sach = new Dausach(maDS, tenSach, namXb, ngayNhap, gia, soLuong, linhVuc, nhaXB, tacGia, tinhTrang);
                    ds.updateDauSach(Sach);
                    GUI_Viewbook_Load(sender, e);
                    reset();

                }
            }
            catch
            {
                MessageBox.Show("Cập nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Viewbook_Load(sender, e);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maDS = txtmaDS.Text;
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ds.deleteDauSach(maDS);
                    GUI_Viewbook_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                    reset();

                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Viewbook_Load(sender, e);
            }
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
