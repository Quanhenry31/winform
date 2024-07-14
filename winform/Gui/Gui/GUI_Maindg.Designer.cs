namespace Gui
{
    partial class GUI_Maindg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSach = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXemsach = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDocgia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTtdg = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhieumuon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddphieumuon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTtphieumuon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChitiettv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTt = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinThủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHotro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSach,
            this.btnDocgia,
            this.btnPhieumuon,
            this.btnChitiettv,
            this.btnTt,
            this.btnHotro,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSach
            // 
            this.btnSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXemsach});
            this.btnSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Image = global::Gui.Properties.Resources.book;
            this.btnSach.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(131, 68);
            this.btnSach.Text = "Sách";
            // 
            // btnXemsach
            // 
            this.btnXemsach.Image = global::Gui.Properties.Resources.book_xem;
            this.btnXemsach.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXemsach.Name = "btnXemsach";
            this.btnXemsach.Size = new System.Drawing.Size(268, 70);
            this.btnXemsach.Text = "Sách";
            this.btnXemsach.Click += new System.EventHandler(this.btnXemsach_Click);
            // 
            // btnDocgia
            // 
            this.btnDocgia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTtdg});
            this.btnDocgia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocgia.Image = global::Gui.Properties.Resources.độcgia;
            this.btnDocgia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDocgia.Name = "btnDocgia";
            this.btnDocgia.Size = new System.Drawing.Size(157, 68);
            this.btnDocgia.Text = "Độc giả";
            this.btnDocgia.Click += new System.EventHandler(this.btnDocgia_Click);
            // 
            // btnTtdg
            // 
            this.btnTtdg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTtdg.Image = global::Gui.Properties.Resources.TT_hocsinh;
            this.btnTtdg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTtdg.Name = "btnTtdg";
            this.btnTtdg.Size = new System.Drawing.Size(296, 70);
            this.btnTtdg.Text = "Thông tin độc giả";
            this.btnTtdg.Click += new System.EventHandler(this.btnTtdg_Click);
            // 
            // btnPhieumuon
            // 
            this.btnPhieumuon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddphieumuon,
            this.btnTtphieumuon});
            this.btnPhieumuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieumuon.Image = global::Gui.Properties.Resources.tickets;
            this.btnPhieumuon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPhieumuon.Name = "btnPhieumuon";
            this.btnPhieumuon.Size = new System.Drawing.Size(195, 68);
            this.btnPhieumuon.Text = "Phiếu mượn";
            // 
            // btnAddphieumuon
            // 
            this.btnAddphieumuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddphieumuon.Image = global::Gui.Properties.Resources.icons8_new_ticket_64;
            this.btnAddphieumuon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddphieumuon.Name = "btnAddphieumuon";
            this.btnAddphieumuon.Size = new System.Drawing.Size(337, 70);
            this.btnAddphieumuon.Text = "Thêm phiếu mượn";
            this.btnAddphieumuon.Click += new System.EventHandler(this.btnAddphieumuon_Click);
            // 
            // btnTtphieumuon
            // 
            this.btnTtphieumuon.Image = global::Gui.Properties.Resources.support_ticket;
            this.btnTtphieumuon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTtphieumuon.Name = "btnTtphieumuon";
            this.btnTtphieumuon.Size = new System.Drawing.Size(337, 70);
            this.btnTtphieumuon.Text = "Thông tin phiếu mượn";
            this.btnTtphieumuon.Click += new System.EventHandler(this.btnTtphieumuon_Click);
            // 
            // btnChitiettv
            // 
            this.btnChitiettv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitiettv.Image = global::Gui.Properties.Resources.detail_thuvien;
            this.btnChitiettv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChitiettv.Name = "btnChitiettv";
            this.btnChitiettv.Size = new System.Drawing.Size(263, 68);
            this.btnChitiettv.Text = "Chi tiết phiếu mượn";
            this.btnChitiettv.Click += new System.EventHandler(this.btnChitiettv_Click);
            // 
            // btnTt
            // 
            this.btnTt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinThủThưToolStripMenuItem});
            this.btnTt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTt.Image = global::Gui.Properties.Resources.tt_thuthu;
            this.btnTt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTt.Name = "btnTt";
            this.btnTt.Size = new System.Drawing.Size(157, 68);
            this.btnTt.Text = "Thủ thư";
            this.btnTt.Click += new System.EventHandler(this.btnTt_Click);
            // 
            // thôngTinThủThưToolStripMenuItem
            // 
            this.thôngTinThủThưToolStripMenuItem.Image = global::Gui.Properties.Resources.Thong_tin_thu_thu;
            this.thôngTinThủThưToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thôngTinThủThưToolStripMenuItem.Name = "thôngTinThủThưToolStripMenuItem";
            this.thôngTinThủThưToolStripMenuItem.Size = new System.Drawing.Size(295, 70);
            this.thôngTinThủThưToolStripMenuItem.Text = "Thông tin thủ thư";
            this.thôngTinThủThưToolStripMenuItem.Click += new System.EventHandler(this.thôngTinThủThưToolStripMenuItem_Click);
            // 
            // btnHotro
            // 
            this.btnHotro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotro.Image = global::Gui.Properties.Resources.icons8_help_641;
            this.btnHotro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHotro.Name = "btnHotro";
            this.btnHotro.Size = new System.Drawing.Size(147, 68);
            this.btnHotro.Text = "Hỗ trợ";
            this.btnHotro.Click += new System.EventHandler(this.btnHotro_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Gui.Properties.Resources.icons8_exit_641;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 68);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GUI_Maindg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui.Properties.Resources.thu_vien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 507);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Maindg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaindg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaindg_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSach;
        private System.Windows.Forms.ToolStripMenuItem btnXemsach;
        private System.Windows.Forms.ToolStripMenuItem btnDocgia;
        private System.Windows.Forms.ToolStripMenuItem btnTtdg;
        private System.Windows.Forms.ToolStripMenuItem btnPhieumuon;
        private System.Windows.Forms.ToolStripMenuItem btnAddphieumuon;
        private System.Windows.Forms.ToolStripMenuItem btnTtphieumuon;
        private System.Windows.Forms.ToolStripMenuItem btnChitiettv;
        private System.Windows.Forms.ToolStripMenuItem btnTt;
        private System.Windows.Forms.ToolStripMenuItem thôngTinThủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHotro;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
    }
}