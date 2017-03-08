namespace EczaDeposu
{
    partial class SiparisOnayla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOnayla));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.onaylaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.temizleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iptalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.basariDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbFatura = new System.Windows.Forms.RichTextBox();
            this.cbSiparisler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIlacAdi = new System.Windows.Forms.Label();
            this.labelSiparisAdet = new System.Windows.Forms.Label();
            this.labelBirimFiyat = new System.Windows.Forms.Label();
            this.labelSiparisTarih = new System.Windows.Forms.Label();
            this.labelTutar = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator,
            this.onaylaToolStripButton,
            this.temizleToolStripButton,
            this.iptalToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(145, 24);
            this.toolStripLabel1.Text = "Siparis Onaylama Islemleri";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // onaylaToolStripButton
            // 
            this.onaylaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.onaylaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("onaylaToolStripButton.Image")));
            this.onaylaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.onaylaToolStripButton.Name = "onaylaToolStripButton";
            this.onaylaToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.onaylaToolStripButton.Text = "&Onayla";
            this.onaylaToolStripButton.Click += new System.EventHandler(this.onaylaToolStripButton_Click);
            // 
            // temizleToolStripButton
            // 
            this.temizleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.temizleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("temizleToolStripButton.Image")));
            this.temizleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.temizleToolStripButton.Name = "temizleToolStripButton";
            this.temizleToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.temizleToolStripButton.Text = "&Temizle";
            this.temizleToolStripButton.Click += new System.EventHandler(this.temizleToolStripButton_Click);
            // 
            // iptalToolStripButton
            // 
            this.iptalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iptalToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("iptalToolStripButton.Image")));
            this.iptalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iptalToolStripButton.Name = "iptalToolStripButton";
            this.iptalToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.iptalToolStripButton.Text = "&Iptal";
            this.iptalToolStripButton.Click += new System.EventHandler(this.iptalToolStripButton_Click);
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
            this.statusStrip1.TabIndex = 4;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtbFatura);
            this.groupBox1.Controls.Add(this.cbSiparisler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparisler Listeleniyor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Siparis Bilgileri";
            // 
            // rtbFatura
            // 
            this.rtbFatura.Location = new System.Drawing.Point(124, 61);
            this.rtbFatura.Name = "rtbFatura";
            this.rtbFatura.ReadOnly = true;
            this.rtbFatura.Size = new System.Drawing.Size(294, 57);
            this.rtbFatura.TabIndex = 2;
            this.rtbFatura.Text = "";
            // 
            // cbSiparisler
            // 
            this.cbSiparisler.FormattingEnabled = true;
            this.cbSiparisler.Location = new System.Drawing.Point(124, 22);
            this.cbSiparisler.Name = "cbSiparisler";
            this.cbSiparisler.Size = new System.Drawing.Size(159, 26);
            this.cbSiparisler.TabIndex = 1;
            this.cbSiparisler.SelectedIndexChanged += new System.EventHandler(this.cbSiparisler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siparis No";
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(302, 188);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(85, 34);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "&Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(197, 188);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 34);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.Location = new System.Drawing.Point(93, 188);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(85, 34);
            this.btnOnayla.TabIndex = 10;
            this.btnOnayla.Text = "&Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.labelTutar);
            this.groupBox2.Controls.Add(this.labelSiparisTarih);
            this.groupBox2.Controls.Add(this.labelBirimFiyat);
            this.groupBox2.Controls.Add(this.labelSiparisAdet);
            this.groupBox2.Controls.Add(this.labelIlacAdi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 124);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FATURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ILAC ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "SIPARIS ADETI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "BIRIM FIYAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "TARIH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "TUTAR:";
            // 
            // labelIlacAdi
            // 
            this.labelIlacAdi.AutoSize = true;
            this.labelIlacAdi.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIlacAdi.Location = new System.Drawing.Point(6, 55);
            this.labelIlacAdi.Name = "labelIlacAdi";
            this.labelIlacAdi.Size = new System.Drawing.Size(11, 18);
            this.labelIlacAdi.TabIndex = 5;
            this.labelIlacAdi.Text = " ";
            // 
            // labelSiparisAdet
            // 
            this.labelSiparisAdet.AutoSize = true;
            this.labelSiparisAdet.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiparisAdet.Location = new System.Drawing.Point(113, 55);
            this.labelSiparisAdet.Name = "labelSiparisAdet";
            this.labelSiparisAdet.Size = new System.Drawing.Size(20, 18);
            this.labelSiparisAdet.TabIndex = 6;
            this.labelSiparisAdet.Text = "    ";
            // 
            // labelBirimFiyat
            // 
            this.labelBirimFiyat.AutoSize = true;
            this.labelBirimFiyat.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirimFiyat.Location = new System.Drawing.Point(207, 55);
            this.labelBirimFiyat.Name = "labelBirimFiyat";
            this.labelBirimFiyat.Size = new System.Drawing.Size(23, 18);
            this.labelBirimFiyat.TabIndex = 7;
            this.labelBirimFiyat.Text = "     ";
            // 
            // labelSiparisTarih
            // 
            this.labelSiparisTarih.AutoSize = true;
            this.labelSiparisTarih.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiparisTarih.Location = new System.Drawing.Point(300, 55);
            this.labelSiparisTarih.Name = "labelSiparisTarih";
            this.labelSiparisTarih.Size = new System.Drawing.Size(23, 18);
            this.labelSiparisTarih.TabIndex = 8;
            this.labelSiparisTarih.Text = "     ";
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutar.Location = new System.Drawing.Point(311, 85);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(23, 18);
            this.labelTutar.TabIndex = 9;
            this.labelTutar.Text = "     ";
            // 
            // SiparisOnayla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SiparisOnayla";
            this.Text = "SiparisOnayla";
            this.Load += new System.EventHandler(this.SiparisOnayla_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton onaylaToolStripButton;
        private System.Windows.Forms.ToolStripButton temizleToolStripButton;
        private System.Windows.Forms.ToolStripButton iptalToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel basariDurumu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbFatura;
        private System.Windows.Forms.ComboBox cbSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Label labelSiparisTarih;
        private System.Windows.Forms.Label labelBirimFiyat;
        private System.Windows.Forms.Label labelSiparisAdet;
        private System.Windows.Forms.Label labelIlacAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}