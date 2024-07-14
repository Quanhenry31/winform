using BUS;
using DLL;
using DTO;
using Microsoft.VisualBasic;
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
    public partial class GUI_Addpm : Form
    {
        BUS_Phieumuon pm = new BUS_Phieumuon();
        BUS_Dausach ds = new BUS_Dausach();
        public GUI_Addpm()
        {
            InitializeComponent();
        }

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)

        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string SoPhieu = txtSophieu.Text;
            string Sothe = cbSothe.Text;
            string maDS = txtMasach.Text;
            DateTime ngayMuon = DateTime.Parse(dpNgaymuon.Text);
            DateTime ngayTra = DateTime.Parse(dpNgaytra.Text);
            string Matt = cbMatt.Text;
            int soLuong = int.Parse(txtSoluong.Text);
           
                    
            try
            {
                 if (MessageBox.Show("Bạn có muốn thêm phiếu mượn này không?","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                     {

                     Phieumuon PM = new Phieumuon(SoPhieu, Sothe, maDS, ngayMuon, ngayTra, Matt , soLuong);
                     pm.themPhieumuon(PM);

                     Dausach_pm dausach = new Dausach_pm( maDS , soLuong);
                     ds.updateDauSach_PM(dausach);
                     MessageBox.Show("Thêm thành công !");
                     reset();

                 }

            }
            catch
            {
                pm.xoaPhieumuon(Sothe);
                MessageBox.Show("Xem lại thông tin phiếu mượn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GUI_Addpm_Load(sender, e);

            }

        }

        private void GUI_Addpm_Load(object sender, EventArgs e)
        {
            cbSothe.DataSource = pm.Getsothe();
            cbSothe.ValueMember = "Sothe";
            cbMatt.DataSource = pm.Getmatt();
            cbMatt.ValueMember = "Matt";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            txtSophieu.Text = "";
            txtMasach.Text = "";
            cbSothe.Text = "";
            dpNgaymuon.Text = "";
            dpNgaytra.Text = "";
            cbMatt.Text = "";
            txtSoluong.Text = "";
        }
    }
}
