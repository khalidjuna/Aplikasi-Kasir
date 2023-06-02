namespace aplikasi_kasir.Gui
{
    partial class FMenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuUtama));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolBarang = new System.Windows.Forms.ToolStripButton();
            this.ToolTransaksi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolExit = new System.Windows.Forms.ToolStripButton();
            this.AboutProgrammer = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_barang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarang,
            this.ToolTransaksi,
            this.toolStripSeparator1,
            this.ToolExit,
            this.AboutProgrammer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolBarang
            // 
            this.ToolBarang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarang.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarang.Image")));
            this.ToolBarang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarang.Name = "ToolBarang";
            this.ToolBarang.Size = new System.Drawing.Size(23, 22);
            this.ToolBarang.Text = "Toolbarang";
            this.ToolBarang.ToolTipText = "Tampilkan data barang";
            this.ToolBarang.Click += new System.EventHandler(this.ToolBarang_Click);
            // 
            // ToolTransaksi
            // 
            this.ToolTransaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("ToolTransaksi.Image")));
            this.ToolTransaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTransaksi.Name = "ToolTransaksi";
            this.ToolTransaksi.Size = new System.Drawing.Size(23, 22);
            this.ToolTransaksi.Text = "Tooltransaksi";
            this.ToolTransaksi.ToolTipText = "Tampilkan data transaksi";
            this.ToolTransaksi.Click += new System.EventHandler(this.ToolTransaksi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolExit
            // 
            this.ToolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolExit.Image = ((System.Drawing.Image)(resources.GetObject("ToolExit.Image")));
            this.ToolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolExit.Name = "ToolExit";
            this.ToolExit.Size = new System.Drawing.Size(23, 22);
            this.ToolExit.Text = "toolStripButton4";
            this.ToolExit.ToolTipText = "Keluar Aplikasi";
            this.ToolExit.Click += new System.EventHandler(this.ToolExit_Click);
            // 
            // AboutProgrammer
            // 
            this.AboutProgrammer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutProgrammer.BackgroundImage")));
            this.AboutProgrammer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutProgrammer.Image = ((System.Drawing.Image)(resources.GetObject("AboutProgrammer.Image")));
            this.AboutProgrammer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutProgrammer.Name = "AboutProgrammer";
            this.AboutProgrammer.Size = new System.Drawing.Size(23, 22);
            this.AboutProgrammer.Text = "&AboutProgrammer";
            this.AboutProgrammer.Click += new System.EventHandler(this.ToolAboutProgrammer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jam Digital";
            // 
            // MenuUser
            // 
            this.MenuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_login,
            this.Submenu_logout,
            this.Submenu_exit});
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(42, 20);
            this.MenuUser.Text = "User";
            // 
            // Submenu_login
            // 
            this.Submenu_login.Image = ((System.Drawing.Image)(resources.GetObject("Submenu_login.Image")));
            this.Submenu_login.Name = "Submenu_login";
            this.Submenu_login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.Submenu_login.Size = new System.Drawing.Size(155, 22);
            this.Submenu_login.Text = "Login";
            this.Submenu_login.Click += new System.EventHandler(this.Submenu_login_Click);
            // 
            // Submenu_logout
            // 
            this.Submenu_logout.Image = ((System.Drawing.Image)(resources.GetObject("Submenu_logout.Image")));
            this.Submenu_logout.Name = "Submenu_logout";
            this.Submenu_logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Submenu_logout.Size = new System.Drawing.Size(155, 22);
            this.Submenu_logout.Text = "Logout";
            this.Submenu_logout.Click += new System.EventHandler(this.Submenu_logout_Click);
            // 
            // Submenu_exit
            // 
            this.Submenu_exit.Image = ((System.Drawing.Image)(resources.GetObject("Submenu_exit.Image")));
            this.Submenu_exit.Name = "Submenu_exit";
            this.Submenu_exit.Size = new System.Drawing.Size(155, 22);
            this.Submenu_exit.Text = "Exit";
            this.Submenu_exit.Click += new System.EventHandler(this.Submenu_exit_Click);
            // 
            // MenuMaster
            // 
            this.MenuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_barang});
            this.MenuMaster.Name = "MenuMaster";
            this.MenuMaster.Size = new System.Drawing.Size(55, 20);
            this.MenuMaster.Text = "Master";
            // 
            // Submenu_barang
            // 
            this.Submenu_barang.Name = "Submenu_barang";
            this.Submenu_barang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.Submenu_barang.Size = new System.Drawing.Size(148, 22);
            this.Submenu_barang.Text = "Barang";
            this.Submenu_barang.Click += new System.EventHandler(this.Submenu_barang_Click);
            // 
            // MenuTransaction
            // 
            this.MenuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_penjualan});
            this.MenuTransaction.Name = "MenuTransaction";
            this.MenuTransaction.Size = new System.Drawing.Size(79, 20);
            this.MenuTransaction.Text = "&Transaction";
            // 
            // Submenu_penjualan
            // 
            this.Submenu_penjualan.Name = "Submenu_penjualan";
            this.Submenu_penjualan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.Submenu_penjualan.Size = new System.Drawing.Size(163, 22);
            this.Submenu_penjualan.Text = "Penjualan";
            this.Submenu_penjualan.Click += new System.EventHandler(this.Submenu_penjualan_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser,
            this.MenuMaster,
            this.MenuTransaction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Sistem Kasir Rep.com ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMenuUtama_Load);
            this.Click += new System.EventHandler(this.FMenuUtama_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton ToolBarang;
        public System.Windows.Forms.ToolStripButton ToolTransaksi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton ToolExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton AboutProgrammer;
        public System.Windows.Forms.ToolStripMenuItem MenuUser;
        public System.Windows.Forms.ToolStripMenuItem Submenu_login;
        public System.Windows.Forms.ToolStripMenuItem Submenu_logout;
        private System.Windows.Forms.ToolStripMenuItem Submenu_exit;
        public System.Windows.Forms.ToolStripMenuItem MenuMaster;
        public System.Windows.Forms.ToolStripMenuItem Submenu_barang;
        public System.Windows.Forms.ToolStripMenuItem MenuTransaction;
        public System.Windows.Forms.ToolStripMenuItem Submenu_penjualan;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}