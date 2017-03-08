namespace EczaDeposu
{
    partial class SiparisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkle));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.olusturToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.temizleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iptalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.npSiparisAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiparisEdilenIlac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEczaneList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbFatura = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.basariDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npSiparisAdet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator,
            this.olusturToolStripButton,
            this.temizleToolStripButton,
            this.iptalToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(147, 24);
            this.toolStripLabel1.Text = "Siparis Olusturma Islemleri";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // olusturToolStripButton
            // 
            this.olusturToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.olusturToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("olusturToolStripButton.Image")));
            this.olusturToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.olusturToolStripButton.Name = "olusturToolStripButton";
            this.olusturToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.olusturToolStripButton.Text = "&New";
            this.olusturToolStripButton.Click += new System.EventHandler(this.olusturToolStripButton_Click);
            // 
            // temizleToolStripButton
            // 
            this.temizleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.temizleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("temizleToolStripButton.Image")));
            this.temizleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.temizleToolStripButton.Name = "temizleToolStripButton";
            this.temizleToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.temizleToolStripButton.Text = "&Open";
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
            this.iptalToolStripButton.Click += new System.EventHandler(this.iptalToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpSiparisTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.npSiparisAdet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSiparisEdilenIlac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEczaneList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparis Olusturma";
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSiparisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(176, 139);
            this.dtpSiparisTarihi.MinDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(151, 21);
            this.dtpSiparisTarihi.TabIndex = 9;
            this.dtpSiparisTarihi.Value = new System.DateTime(2017, 1, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Siparis Tarihi";
            // 
            // npSiparisAdet
            // 
            this.npSiparisAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npSiparisAdet.Location = new System.Drawing.Point(176, 102);
            this.npSiparisAdet.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.npSiparisAdet.Name = "npSiparisAdet";
            this.npSiparisAdet.Size = new System.Drawing.Size(120, 21);
            this.npSiparisAdet.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Siparis Adedi";
            // 
            // txtSiparisEdilenIlac
            // 
            this.txtSiparisEdilenIlac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiparisEdilenIlac.Location = new System.Drawing.Point(176, 62);
            this.txtSiparisEdilenIlac.Name = "txtSiparisEdilenIlac";
            this.txtSiparisEdilenIlac.Size = new System.Drawing.Size(120, 21);
            this.txtSiparisEdilenIlac.TabIndex = 5;
            this.txtSiparisEdilenIlac.Tag = "";
            this.txtSiparisEdilenIlac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiparisEdilenIlac_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Siparis Edilen Ilac Adi";
            // 
            // cbEczaneList
            // 
            this.cbEczaneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEczaneList.FormattingEnabled = true;
            this.cbEczaneList.Location = new System.Drawing.Point(176, 21);
            this.cbEczaneList.Name = "cbEczaneList";
            this.cbEczaneList.Size = new System.Drawing.Size(219, 23);
            this.cbEczaneList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilac Siparisi Veren Eczane";
            // 
            // rtbFatura
            // 
            this.rtbFatura.Location = new System.Drawing.Point(12, 270);
            this.rtbFatura.Name = "rtbFatura";
            this.rtbFatura.Size = new System.Drawing.Size(441, 96);
            this.rtbFatura.TabIndex = 2;
            this.rtbFatura.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.basariDurumu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 22);
            this.statusStrip1.TabIndex = 3;
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
            this.basariDurumu.Size = new System.Drawing.Size(19, 17);
            this.basariDurumu.Text = "    ";
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(302, 218);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(85, 34);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "&Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(197, 218);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 34);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlustur.Location = new System.Drawing.Point(93, 218);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(85, 34);
            this.btnOlustur.TabIndex = 7;
            this.btnOlustur.Text = "&Olustur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // SiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 400);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbFatura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "SiparisEkle";
            this.Text = "SiparisEkle";
            this.Load += new System.EventHandler(this.SiparisEkle_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npSiparisAdet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton olusturToolStripButton;
        private System.Windows.Forms.ToolStripButton temizleToolStripButton;
        private System.Windows.Forms.ToolStripButton iptalToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEczaneList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiparisEdilenIlac;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown npSiparisAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbFatura;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel basariDurumu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOlustur;
    }
}