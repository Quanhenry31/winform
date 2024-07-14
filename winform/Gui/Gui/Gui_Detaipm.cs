using DLL;
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
    public partial class Gui_Detaipm : Form
    {
        BUS_Phieumuon pm = new BUS_Phieumuon();
        public Gui_Detaipm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gui_Detaipm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pm.Phieumuon_chitiet();
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            string tensach = btnTim.Text;
            string sophieu = tensach;
            dataGridView1.DataSource = pm.Tim_pm(tensach, sophieu);
        }
    }
}
