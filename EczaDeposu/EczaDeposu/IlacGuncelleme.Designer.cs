namespace EczaDeposu
{
    partial class IlacGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlacGuncelleme));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guncelleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.temizleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iptalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.basariDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSonKullanma = new System.Windows.Forms.DateTimePicker();
            this.nupStokAdedi = new System.Windows.Forms.NumericUpDown();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStokAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.guncelleToolStripButton,
            this.temizleToolStripButton,
            this.iptalToolStripButton,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(501, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(138, 24);
            this.toolStripLabel1.Text = "Ilac Guncelleme Islemleri";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // guncelleToolStripButton
            // 
            this.guncelleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guncelleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guncelleToolStripButton.Image")));
            this.guncelleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guncelleToolStripButton.Name = "guncelleToolStripButton";
            this.guncelleToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.guncelleToolStripButton.Text = "&New";
            this.guncelleToolStripButton.ToolTipText = "Guncelle";
            this.guncelleToolStripButton.Click += new System.EventHandler(this.guncelleToolStripButton_Click);
            // 
            // temizleToolStripButton
            // 
            this.temizleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.temizleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("temizleToolStripButton.Image")));
            this.temizleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.temizleToolStripButton.Name = "temizleToolStripButton";
            this.temizleToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.temizleToolStripButton.Text = "&Open";
            this.temizleToolStripButton.ToolTipText = "Temizle";
            this.temizleToolStripButton.Click += new System.EventHandler(this.temizleToolStripButton_Click);
            // 
            // iptalToolStripButton
            // 
            this.iptalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iptalToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("iptalToolStripButton.Image")));
            this.iptalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iptalToolStripButton.Name = "iptalToolStripButton";
            this.iptalToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.iptalToolStripButton.Text = "&Save";
            this.iptalToolStripButton.ToolTipText = "Iptal";
            this.iptalToolStripButton.Click += new System.EventHandler(this.iptalToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.basariDurumu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(501, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Islem Durumu";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = ":";
            // 
            // basariDurumu
            // 
            this.basariDurumu.Name = "basariDurumu";
            this.basariDurumu.Size = new System.Drawing.Size(22, 17);
            this.basariDurumu.Text = "     ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBul);
            this.groupBox1.Controls.Add(this.txtBarkodNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rtbAciklama);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpSonKullanma);
            this.groupBox1.Controls.Add(this.nupStokAdedi);
            this.groupBox1.Controls.Add(this.txtBirimFiyat);
            this.groupBox1.Controls.Add(this.txtFirmaAdi);
            this.groupBox1.Controls.Add(this.txtIlacAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 333);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ilac Guncelleme";
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBul.Location = new System.Drawing.Point(327, 69);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 24);
            this.btnBul.TabIndex = 26;
            this.btnBul.Text = "&Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodNo.Location = new System.Drawing.Point(296, 41);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(107, 23);
            this.txtBarkodNo.TabIndex = 25;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            this.txtBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Guncellemek Istediginiz Ilacin Barkodunu Girin";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAciklama.Location = new System.Drawing.Point(246, 159);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(156, 60);
            this.rtbAciklama.TabIndex = 23;
            this.rtbAciklama.Text = "";
            this.rtbAciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbAciklama_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Aciklama";
            // 
            // dtpSonKullanma
            // 
            this.dtpSonKullanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSonKullanma.Location = new System.Drawing.Point(248, 301);
            this.dtpSonKullanma.MinDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dtpSonKullanma.Name = "dtpSonKullanma";
            this.dtpSonKullanma.Size = new System.Drawing.Size(154, 20);
            this.dtpSonKullanma.TabIndex = 21;
            this.dtpSonKullanma.Value = new System.DateTime(2017, 1, 2, 0, 0, 0, 0);
            // 
            // nupStokAdedi
            // 
            this.nupStokAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupStokAdedi.Location = new System.Drawing.Point(246, 259);
            this.nupStokAdedi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupStokAdedi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupStokAdedi.Name = "nupStokAdedi";
            this.nupStokAdedi.Size = new System.Drawing.Size(156, 20);
            this.nupStokAdedi.TabIndex = 20;
            this.nupStokAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(246, 225);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(156, 23);
            this.txtBirimFiyat.TabIndex = 19;
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyat_KeyPress);
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(246, 131);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(156, 23);
            this.txtFirmaAdi.TabIndex = 18;
            this.txtFirmaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirmaAdi_KeyPress);
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIlacAdi.Location = new System.Drawing.Point(246, 105);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(156, 23);
            this.txtIlacAdi.TabIndex = 17;
            this.txtIlacAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIlacAdi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Son Kullanma Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Birim Fiyati ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Uretici Firmasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ilacin Adi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(90, 379);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 34);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "&Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(201, 379);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 34);
            this.btnTemizle.TabIndex = 27;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(305, 379);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 34);
            this.btnCikis.TabIndex = 28;
            this.btnCikis.Text = "&Iptal";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // IlacGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 447);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "IlacGuncelleme";
            this.Text = "IlacGuncelleme";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStokAdedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton guncelleToolStripButton;
        private System.Windows.Forms.ToolStripButton temizleToolStripButton;
        private System.Windows.Forms.ToolStripButton iptalToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel basariDurumu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpSonKullanma;
        private System.Windows.Forms.NumericUpDown nupStokAdedi;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBul;
    }
}