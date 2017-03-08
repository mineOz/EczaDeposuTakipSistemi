namespace EczaDeposu
{
    partial class StokIslemleriMDI
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
            this.stokListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümİlaçlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçTürüneGöreListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokTopluSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stokListeleToolStripMenuItem
            // 
            this.stokListeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümİlaçlarıListeleToolStripMenuItem,
            this.ilaçTürüneGöreListeleToolStripMenuItem});
            this.stokListeleToolStripMenuItem.Name = "stokListeleToolStripMenuItem";
            this.stokListeleToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.stokListeleToolStripMenuItem.Text = "Stok Listele";
            // 
            // tümİlaçlarıListeleToolStripMenuItem
            // 
            this.tümİlaçlarıListeleToolStripMenuItem.Name = "tümİlaçlarıListeleToolStripMenuItem";
            this.tümİlaçlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.tümİlaçlarıListeleToolStripMenuItem.Text = "Tüm İlaçları Listele";
            this.tümİlaçlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.tümİlaçlarıListeleToolStripMenuItem_Click);
            // 
            // ilaçTürüneGöreListeleToolStripMenuItem
            // 
            this.ilaçTürüneGöreListeleToolStripMenuItem.Name = "ilaçTürüneGöreListeleToolStripMenuItem";
            this.ilaçTürüneGöreListeleToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.ilaçTürüneGöreListeleToolStripMenuItem.Text = "İlaç Türüne Göre Listele";
            this.ilaçTürüneGöreListeleToolStripMenuItem.Click += new System.EventHandler(this.ilaçTürüneGöreListeleToolStripMenuItem_Click);
            // 
            // stokTopluSilmeToolStripMenuItem
            // 
            this.stokTopluSilmeToolStripMenuItem.Name = "stokTopluSilmeToolStripMenuItem";
            this.stokTopluSilmeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.stokTopluSilmeToolStripMenuItem.Text = "Stok Toplu Silme";
            this.stokTopluSilmeToolStripMenuItem.Click += new System.EventHandler(this.stokTopluSilmeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokListeleToolStripMenuItem,
            this.stokTopluSilmeToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // StokIslemleriMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::EczaDeposu.Properties.Resources.ilac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 549);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StokIslemleriMDI";
            this.Text = "Stok Islemleri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem stokListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokTopluSilmeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümİlaçlarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçTürüneGöreListeleToolStripMenuItem;
    }
}