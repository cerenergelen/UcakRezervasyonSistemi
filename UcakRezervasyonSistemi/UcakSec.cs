using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyonSistemi
{
    public partial class UcakSec : Form
    {
        RezervasyonForm rezervasyonForm;
        long secilenUcakId = -1;
        public UcakSec(RezervasyonForm form)
        {
            InitializeComponent();
            this.rezervasyonForm = form;
        }

        private void UcakSec_Load(object sender, EventArgs e)
        {
            List<Lokasyon> lokasyonlar;
            var sessionFactory = UcakSessionFactory.OpenSession();

            using (var session = sessionFactory.OpenSession())
            {
                lokasyonlar = session.Query<Lokasyon>().ToList();
            }

            var cbItems = lokasyonlar.Select(l => $"{l.Id}-{l.Sehir} {l.Havaalani}").ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cbItems;
            cbLokasyon.DataSource = bindingSource;

            cbLokasyon.SelectedIndex = 0;
        }

        private void cbLokasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLokasyon.SelectedIndex >= 0)
            {
                Lokasyon lokasyon = null;
                long secilenLokasyonId = long.Parse(cbLokasyon.SelectedItem.ToString().Split('-')[0]);

                List<Ucak> ucaklar;
                var sessionFactory = UcakSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    ucaklar = session.Query<Ucak>().Where(u => u.Lokasyon.Id == secilenLokasyonId).ToList();
                    lokasyon = session.Query<Lokasyon>().Where(x => x.Id == secilenLokasyonId).FirstOrDefault();
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ucaklar;
                dgUcuslar.DataSource = bindingSource;
                lblUlke.Text = lokasyon.Ulke;
                lblSehir.Text = lokasyon.Sehir;
                lblHavaalani.Text = lokasyon.Havaalani;
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (secilenUcakId != -1)
            {
                rezervasyonForm.ucakId = secilenUcakId;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Bir uçuş seçiniz.");
        }

        private void dgUcuslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgUcuslar.Rows[e.RowIndex];
                secilenUcakId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            RectangleF yazdirmaAlani = e.PageSettings.PrintableArea;

            int genislik = this.Width;
            int yukseklik = this.Height;

            float olcek = Math.Min(yazdirmaAlani.Width / genislik, yazdirmaAlani.Height / yukseklik);
            int yeniGenislik = (int)(genislik * olcek);
            int yeniYukseklik = (int)(yukseklik * olcek);

            using (Bitmap bitmap = new Bitmap(yeniGenislik, yeniYukseklik))
            {
                this.DrawToBitmap(bitmap, new Rectangle(0, 0, yeniGenislik, yeniYukseklik));
                graphics.DrawImage(bitmap, yazdirmaAlani.Location);
            }
        }
    }
}
