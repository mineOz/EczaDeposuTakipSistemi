namespace EczaDeposu
{
    partial class TureGoreListele
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListeletreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilaçlar Turune Göre Listeleniyor\r\n\r\n";
            // 
            // ListeletreeView
            // 
            this.ListeletreeView.Location = new System.Drawing.Point(13, 40);
            this.ListeletreeView.Name = "ListeletreeView";
            this.ListeletreeView.Size = new System.Drawing.Size(666, 398);
            this.ListeletreeView.TabIndex = 1;
            // 
            // TureGoreListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.ListeletreeView);
            this.Controls.Add(this.label1);
            this.Name = "TureGoreListele";
            this.Text = "TureGoreListele";
            this.Load += new System.EventHandler(this.TureGoreListele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView ListeletreeView;
    }
}