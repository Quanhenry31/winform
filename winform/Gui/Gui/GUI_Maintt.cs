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
    public partial class GUI_Maintt : Form
    {
        public GUI_Maintt()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddsach_Click(object sender, EventArgs e)
        {
            GUI_Viewbook sach = new GUI_Viewbook();
            sach.ShowDialog();
        }

        private void btnXemsach_Click(object sender, EventArgs e)
        {

            GUI_Book addbook = new GUI_Book();
            addbook.Show();
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {

            GUI_Help help = new GUI_Help();
            help.ShowDialog();
        }

        private void btnAdddg_Click(object sender, EventArgs e)
        {
            GUI_Adddg ds = new GUI_Adddg();
            ds.ShowDialog();
        }

        private void btnTtdg_Click(object sender, EventArgs e)
        {
            GUI_Viewdg ds = new GUI_Viewdg();
            ds.ShowDialog();
        }

        private void btnAddphieumuon_Click(object sender, EventArgs e)
        {
            GUI_Addpm pm = new GUI_Addpm();
            pm.ShowDialog();
        }

        private void btnTtphieumuon_Click(object sender, EventArgs e)
        {
            GUI_Viewpm pm = new GUI_Viewpm();
            pm.ShowDialog();
        }

        private void btnChitietpm_Click(object sender, EventArgs e)
        {
            Gui_Detaipm de = new Gui_Detaipm();
            de.ShowDialog();
        }

        private void thôngTinThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Viewtt tt = new GUI_Viewtt();
            tt.ShowDialog();
        }

        private void ThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Thuthu tt = new GUI_Thuthu();
            tt.ShowDialog();
        }
    }
}
