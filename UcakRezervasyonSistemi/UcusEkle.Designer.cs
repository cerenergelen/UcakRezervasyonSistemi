namespace UcakRezervasyonSistemi
{
    partial class UcusEkle
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
            this.btnSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSeriNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBakimTarihi = new System.Windows.Forms.DateTimePicker();
            this.numericKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(101, 4);
            this.btnSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(140, 19);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Seçiniz";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçilen Lokasyon:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(9, 173);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(232, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(101, 48);
            this.tbModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(140, 20);
            this.tbModel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // tbSeriNo
            // 
            this.tbSeriNo.Location = new System.Drawing.Point(101, 71);
            this.tbSeriNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSeriNo.Name = "tbSeriNo";
            this.tbSeriNo.Size = new System.Drawing.Size(140, 20);
            this.tbSeriNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seri No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kişi Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bakım Tarihi";
            // 
            // dtBakimTarihi
            // 
            this.dtBakimTarihi.Location = new System.Drawing.Point(101, 115);
            this.dtBakimTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtBakimTarihi.Name = "dtBakimTarihi";
            this.dtBakimTarihi.Size = new System.Drawing.Size(140, 20);
            this.dtBakimTarihi.TabIndex = 5;
            // 
            // numericKisiSayisi
            // 
            this.numericKisiSayisi.Location = new System.Drawing.Point(101, 94);
            this.numericKisiSayisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericKisiSayisi.Name = "numericKisiSayisi";
            this.numericKisiSayisi.Size = new System.Drawing.Size(56, 20);
            this.numericKisiSayisi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Uçuş Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 137);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // UcusEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 219);
            this.Controls.Add(this.numericKisiSayisi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtBakimTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSeriNo);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSec);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcusEkle";
            this.Text = "Uçak Ekle";
            this.Load += new System.EventHandler(this.UcusEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericKisiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSeriNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBakimTarihi;
        private System.Windows.Forms.NumericUpDown numericKisiSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}