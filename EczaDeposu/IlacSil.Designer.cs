namespace EczaDeposu
{
    partial class IlacSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlacSil));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.silToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.temizleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iptalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.rbIlacAdi = new System.Windows.Forms.RadioButton();
            this.rbBarkodNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSilinenListele = new System.Windows.Forms.RichTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelBasariDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.basariDurumu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator,
            this.silToolStripButton,
            this.temizleToolStripButton,
            this.iptalToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 24);
            this.toolStripLabel1.Text = "Ilac Silme Islemleri";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // silToolStripButton
            // 
            this.silToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.silToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripButton.Image")));
            this.silToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.silToolStripButton.Name = "silToolStripButton";
            this.silToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.silToolStripButton.Text = "&New";
            this.silToolStripButton.ToolTipText = "Sil";
            this.silToolStripButton.Click += new System.EventHandler(this.silToolStripButton_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBul);
            this.groupBox1.Controls.Add(this.txtBoxID);
            this.groupBox1.Controls.Add(this.rbIlacAdi);
            this.groupBox1.Controls.Add(this.rbBarkodNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(636, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Silinecek Ilac";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(431, 102);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(113, 42);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "&Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(317, 47);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(225, 26);
            this.txtBoxID.TabIndex = 2;
            // 
            // rbIlacAdi
            // 
            this.rbIlacAdi.AutoSize = true;
            this.rbIlacAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIlacAdi.Location = new System.Drawing.Point(187, 47);
            this.rbIlacAdi.Margin = new System.Windows.Forms.Padding(4);
            this.rbIlacAdi.Name = "rbIlacAdi";
            this.rbIlacAdi.Size = new System.Drawing.Size(85, 24);
            this.rbIlacAdi.TabIndex = 1;
            this.rbIlacAdi.TabStop = true;
            this.rbIlacAdi.Text = "Ilac Adi";
            this.rbIlacAdi.UseVisualStyleBackColor = true;
            this.rbIlacAdi.CheckedChanged += new System.EventHandler(this.aramaType_CheckedChanged);
            // 
            // rbBarkodNo
            // 
            this.rbBarkodNo.AutoSize = true;
            this.rbBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBarkodNo.Location = new System.Drawing.Point(37, 47);
            this.rbBarkodNo.Margin = new System.Windows.Forms.Padding(4);
            this.rbBarkodNo.Name = "rbBarkodNo";
            this.rbBarkodNo.Size = new System.Drawing.Size(109, 24);
            this.rbBarkodNo.TabIndex = 0;
            this.rbBarkodNo.TabStop = true;
            this.rbBarkodNo.Text = "Barkod No";
            this.rbBarkodNo.UseVisualStyleBackColor = true;
            this.rbBarkodNo.CheckedChanged += new System.EventHandler(this.aramaType_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek Ilac Goruntuleniyor:";
            // 
            // rtbSilinenListele
            // 
            this.rtbSilinenListele.Location = new System.Drawing.Point(16, 315);
            this.rtbSilinenListele.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSilinenListele.Name = "rtbSilinenListele";
            this.rtbSilinenListele.ReadOnly = true;
            this.rtbSilinenListele.Size = new System.Drawing.Size(635, 117);
            this.rtbSilinenListele.TabIndex = 3;
            this.rtbSilinenListele.Text = "";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(141, 460);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 42);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(272, 460);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(113, 42);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(403, 460);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(113, 42);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "&Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.labelBasariDurumu,
            this.basariDurumu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(668, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 20);
            this.toolStripStatusLabel1.Text = "Islem Durumu";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 20);
            this.toolStripStatusLabel2.Text = ":";
            // 
            // labelBasariDurumu
            // 
            this.labelBasariDurumu.Name = "labelBasariDurumu";
            this.labelBasariDurumu.Size = new System.Drawing.Size(0, 20);
            // 
            // basariDurumu
            // 
            this.basariDurumu.Name = "basariDurumu";
            this.basariDurumu.Size = new System.Drawing.Size(33, 20);
            this.basariDurumu.Text = "      ";
            // 
            // IlacSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.rtbSilinenListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "IlacSil";
            this.Text = "IlacSil";
            this.Load += new System.EventHandler(this.IlacSil_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton silToolStripButton;
        private System.Windows.Forms.ToolStripButton temizleToolStripButton;
        private System.Windows.Forms.ToolStripButton iptalToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.RadioButton rbIlacAdi;
        private System.Windows.Forms.RadioButton rbBarkodNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSilinenListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labelBasariDurumu;
        private System.Windows.Forms.ToolStripStatusLabel basariDurumu;
    }
}