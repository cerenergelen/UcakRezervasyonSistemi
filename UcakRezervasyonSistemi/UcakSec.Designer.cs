namespace UcakRezervasyonSistemi
{
    partial class UcakSec
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
            this.cbLokasyon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHavaalani = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUlke = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgUcuslar = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUcuslar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLokasyon
            // 
            this.cbLokasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLokasyon.FormattingEnabled = true;
            this.cbLokasyon.Location = new System.Drawing.Point(16, 28);
            this.cbLokasyon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLokasyon.Name = "cbLokasyon";
            this.cbLokasyon.Size = new System.Drawing.Size(151, 21);
            this.cbLokasyon.TabIndex = 0;
            this.cbLokasyon.SelectedIndexChanged += new System.EventHandler(this.cbLokasyon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lokasyon Seçiniz:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHavaalani);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSehir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblUlke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lokasyon Bilgisi";
            // 
            // lblHavaalani
            // 
            this.lblHavaalani.Location = new System.Drawing.Point(61, 69);
            this.lblHavaalani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHavaalani.Name = "lblHavaalani";
            this.lblHavaalani.Size = new System.Drawing.Size(85, 13);
            this.lblHavaalani.TabIndex = 0;
            this.lblHavaalani.Text = "------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Havaalanı";
            // 
            // lblSehir
            // 
            this.lblSehir.Location = new System.Drawing.Point(63, 46);
            this.lblSehir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(82, 13);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şehir:";
            // 
            // lblUlke
            // 
            this.lblUlke.Location = new System.Drawing.Point(63, 26);
            this.lblUlke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(82, 13);
            this.lblUlke.TabIndex = 0;
            this.lblUlke.Text = "------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ülke:";
            // 
            // dgUcuslar
            // 
            this.dgUcuslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUcuslar.Location = new System.Drawing.Point(171, 53);
            this.dgUcuslar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgUcuslar.MultiSelect = false;
            this.dgUcuslar.Name = "dgUcuslar";
            this.dgUcuslar.RowHeadersWidth = 51;
            this.dgUcuslar.RowTemplate.Height = 24;
            this.dgUcuslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUcuslar.Size = new System.Drawing.Size(538, 229);
            this.dgUcuslar.TabIndex = 4;
            this.dgUcuslar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUcuslar_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(268, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "Bulunan Uçuşlar";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(171, 287);
            this.btnSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(538, 19);
            this.btnSec.TabIndex = 6;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // UcakSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgUcuslar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLokasyon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcakSec";
            this.Text = "Uçuş Seçiniz";
            this.Load += new System.EventHandler(this.UcakSec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUcuslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLokasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHavaalani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgUcuslar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}