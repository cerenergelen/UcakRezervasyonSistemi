namespace UcakRezervasyonSistemi
{
    partial class LokasyonEkle
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
            this.tbUlke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSehir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHavaalani = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAcikmi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ülke";
            // 
            // tbUlke
            // 
            this.tbUlke.Location = new System.Drawing.Point(107, 16);
            this.tbUlke.Name = "tbUlke";
            this.tbUlke.Size = new System.Drawing.Size(137, 22);
            this.tbUlke.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şehir";
            // 
            // tbSehir
            // 
            this.tbSehir.Location = new System.Drawing.Point(107, 54);
            this.tbSehir.Name = "tbSehir";
            this.tbSehir.Size = new System.Drawing.Size(137, 22);
            this.tbSehir.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hava Alanı";
            // 
            // tbHavaalani
            // 
            this.tbHavaalani.Location = new System.Drawing.Point(107, 94);
            this.tbHavaalani.Name = "tbHavaalani";
            this.tbHavaalani.Size = new System.Drawing.Size(137, 22);
            this.tbHavaalani.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açık mı?";
            // 
            // cbAcikmi
            // 
            this.cbAcikmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcikmi.FormattingEnabled = true;
            this.cbAcikmi.Items.AddRange(new object[] {
            "E",
            "H"});
            this.cbAcikmi.Location = new System.Drawing.Point(107, 138);
            this.cbAcikmi.Name = "cbAcikmi";
            this.cbAcikmi.Size = new System.Drawing.Size(137, 24);
            this.cbAcikmi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LokasyonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAcikmi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHavaalani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUlke);
            this.Controls.Add(this.label1);
            this.Name = "LokasyonEkle";
            this.Text = "Lokasyon Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUlke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHavaalani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAcikmi;
        private System.Windows.Forms.Button button1;
    }
}