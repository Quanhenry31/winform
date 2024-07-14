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
    
    public partial class GUI_Viewpm : Form
    {
        BUS_Phieumuon pm = new BUS_Phieumuon();
        BUS_Dausach ds = new BUS_Dausach();
        public GUI_Viewpm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_Viewpm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pm.Phieumuon();
            cbSothe.DataSource = pm.Getsothe();
            cbSothe.ValueMember = "Sothe";
            cbMatt.DataSource = pm.Getmatt();
            cbMatt.ValueMember = "Matt";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Soluong = int.Parse(txtSoluong.Text);
            string maDS = txtIDsach.Text;

            try
            {
                if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string SoPhieu = txtSophieu.Text;
                    pm.xoaPhieumuon(SoPhieu);
                    MessageBox.Show("Xóa thành công!");


                    Dausach_pm dausach = new Dausach_pm(maDS, Soluong);
                    ds.updateDauSach_PM2(dausach);
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Viewpm_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string SoPhieu = txtSophieu.Text;
            string Sothe = cbSothe.Text;
            string maDS = txtIDsach.Text;
            DateTime ngayMuon = DateTime.Parse(dpNgaymuon.Text);
            DateTime ngayTra = DateTime.Parse(dpNgaytra.Text);
            string Matt = cbMatt.Text;
            int Soluong = int.Parse(txtSoluong.Text);

            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Phieumuon PM = new Phieumuon(SoPhieu, Sothe, maDS, ngayMuon, ngayTra, Matt, Soluong);
                    pm.suaPhieumuon(PM);
                    GUI_Viewpm_Load(sender, e);
                    MessageBox.Show("Cập nhập thành công!");

                }
            }
            catch
            { 
                MessageBox.Show("Cập nhập chưa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Viewpm_Load(sender, e);
            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSophieu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbSothe.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtIDsach.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dpNgaymuon.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()).ToShortDateString();
            dpNgaytra.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()).ToShortDateString();
            cbMatt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSoluong.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        void reset()
        {
            txtSophieu.Text = "";
            txtIDsach.Text = "";
            cbSothe.Text = "";
            dpNgaymuon.Text = "";
            dpNgaytra.Text = "";
            cbMathuthu.Text = "";
            txtSoluong.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            string keyword = txtSeach2.Text;
            dataGridView1.DataSource = pm.Timkiem(keyword);
            reset();
        }
    }
}
