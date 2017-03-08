namespace EczaDeposu
{
    partial class Eczaneler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eczaneler));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ekleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guncelleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.silToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.basariDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEczaneAdi = new System.Windows.Forms.TextBox();
            this.rtbEczaneAdresi = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEczaneTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtGuncelleTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbGuncelleAdres = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuncelleAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEczaneNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbSil = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator,
            this.ekleToolStripButton,
            this.guncelleToolStripButton,
            this.silToolStripButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(501, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(90, 24);
            this.toolStripLabel1.Text = "Eczane Islemleri";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // ekleToolStripButton
            // 
            this.ekleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ekleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ekleToolStripButton.Image")));
            this.ekleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ekleToolStripButton.Name = "ekleToolStripButton";
            this.ekleToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.ekleToolStripButton.Text = "&New";
            this.ekleToolStripButton.ToolTipText = "Ekle";
            this.ekleToolStripButton.Click += new System.EventHandler(this.ekleToolStripButton_Click);
            // 
            // guncelleToolStripButton
            // 
            this.guncelleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guncelleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guncelleToolStripButton.Image")));
            this.guncelleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guncelleToolStripButton.Name = "guncelleToolStripButton";
            this.guncelleToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.guncelleToolStripButton.Text = "&Open";
            this.guncelleToolStripButton.ToolTipText = "Guncelle";
            // 
            // silToolStripButton
            // 
            this.silToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.silToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripButton.Image")));
            this.silToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.silToolStripButton.Name = "silToolStripButton";
            this.silToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.silToolStripButton.Text = "&Save";
            this.silToolStripButton.ToolTipText = "Sil";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Formlari Temizle";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.basariDurumu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
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
            this.basariDurumu.Size = new System.Drawing.Size(16, 17);
            this.basariDurumu.Text = "   ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEczaneAdi);
            this.groupBox1.Controls.Add(this.rtbEczaneAdresi);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtEczaneTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eczane Ekleme";
            // 
            // txtEczaneAdi
            // 
            this.txtEczaneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEczaneAdi.Location = new System.Drawing.Point(169, 30);
            this.txtEczaneAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEczaneAdi.Name = "txtEczaneAdi";
            this.txtEczaneAdi.Size = new System.Drawing.Size(180, 23);
            this.txtEczaneAdi.TabIndex = 8;
            this.txtEczaneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEczaneAdi_KeyPress);
            // 
            // rtbEczaneAdresi
            // 
            this.rtbEczaneAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEczaneAdresi.Location = new System.Drawing.Point(170, 65);
            this.rtbEczaneAdresi.Name = "rtbEczaneAdresi";
            this.rtbEczaneAdresi.Size = new System.Drawing.Size(178, 22);
            this.rtbEczaneAdresi.TabIndex = 7;
            this.rtbEczaneAdresi.Text = "";
            this.rtbEczaneAdresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbEczaneAdresi_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(369, 102);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 25);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "&Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEczaneTel
            // 
            this.txtEczaneTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEczaneTel.Location = new System.Drawing.Point(171, 102);
            this.txtEczaneTel.Name = "txtEczaneTel";
            this.txtEczaneTel.Size = new System.Drawing.Size(178, 23);
            this.txtEczaneTel.TabIndex = 5;
            this.txtEczaneTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEczaneTel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarasi Girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eczane Adresi Girin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eczane Adi Girin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.txtGuncelleTel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rtbGuncelleAdres);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGuncelleAd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbEczaneNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eczane Guncelleme";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(369, 138);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 25);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "&Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtGuncelleTel
            // 
            this.txtGuncelleTel.Location = new System.Drawing.Point(169, 138);
            this.txtGuncelleTel.Name = "txtGuncelleTel";
            this.txtGuncelleTel.Size = new System.Drawing.Size(180, 22);
            this.txtGuncelleTel.TabIndex = 7;
            this.txtGuncelleTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuncelleTel_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telelefon Numarasi";
            // 
            // rtbGuncelleAdres
            // 
            this.rtbGuncelleAdres.Location = new System.Drawing.Point(169, 105);
            this.rtbGuncelleAdres.Name = "rtbGuncelleAdres";
            this.rtbGuncelleAdres.Size = new System.Drawing.Size(180, 27);
            this.rtbGuncelleAdres.TabIndex = 5;
            this.rtbGuncelleAdres.Text = "";
            this.rtbGuncelleAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbGuncelleAdres_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Eczane Adresi";
            // 
            // txtGuncelleAd
            // 
            this.txtGuncelleAd.Location = new System.Drawing.Point(169, 69);
            this.txtGuncelleAd.Name = "txtGuncelleAd";
            this.txtGuncelleAd.Size = new System.Drawing.Size(180, 22);
            this.txtGuncelleAd.TabIndex = 3;
            this.txtGuncelleAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuncelleAd_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Eczane Adi";
            // 
            // cbEczaneNo
            // 
            this.cbEczaneNo.FormattingEnabled = true;
            this.cbEczaneNo.Location = new System.Drawing.Point(170, 36);
            this.cbEczaneNo.Name = "cbEczaneNo";
            this.cbEczaneNo.Size = new System.Drawing.Size(179, 24);
            this.cbEczaneNo.TabIndex = 1;
            this.cbEczaneNo.SelectedIndexChanged += new System.EventHandler(this.cbEczaneNo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Eczane NO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.cbSil);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 79);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eczane Silme";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(369, 31);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 25);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbSil
            // 
            this.cbSil.FormattingEnabled = true;
            this.cbSil.Location = new System.Drawing.Point(163, 31);
            this.cbSil.Name = "cbSil";
            this.cbSil.Size = new System.Drawing.Size(186, 24);
            this.cbSil.TabIndex = 3;
            this.cbSil.SelectedIndexChanged += new System.EventHandler(this.cbSil_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Eczane NO";
            // 
            // Eczaneler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Eczaneler";
            this.Text = "Eczaneler";
            this.Load += new System.EventHandler(this.Eczaneler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ekleToolStripButton;
        private System.Windows.Forms.ToolStripButton guncelleToolStripButton;
        private System.Windows.Forms.ToolStripButton silToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel basariDurumu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbEczaneAdresi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEczaneTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtGuncelleTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbGuncelleAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuncelleAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEczaneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cbSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtEczaneAdi;
    }
}