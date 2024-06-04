using NHibernate.Transform;
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
    public partial class LokasyonSec : Form
    {
        UcusEkle ucusForm;
        int secilenLokasyonId = -1;
        string secilenLokasyon;
        public LokasyonSec(UcusEkle form)
        {
            InitializeComponent();
            ucusForm = form;
        }

        private void LokasyonSec_Load(object sender, EventArgs e)
        {
            List<Lokasyon> list = new List<Lokasyon>();

            var sessionFactory = UcakSessionFactory.OpenSession();

            using (var session = sessionFactory.OpenSession())
            {
                var q = session.CreateSQLQuery("SELECT * FROM Lokasyonlar");

                IList<Lokasyon> results = q.SetResultTransformer(Transformers.AliasToBean(typeof(Lokasyon)))
                                          .List<Lokasyon>();

                list = (List<Lokasyon>)results;
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = list.Select(c => new { c.Id, c.Ulke, c.Sehir, c.Havaalani, c.AcikKapali });

            dgLokasyon.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secilenLokasyonId != -1)
            {
                ucusForm.secilenLokasyon = secilenLokasyon;
                ucusForm.secilenLokasyonId = secilenLokasyonId;
                this.Close();
            }
            else MessageBox.Show("Bir lokasyon seçiniz.");
        }

        private void dgLokasyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgLokasyon.Rows[e.RowIndex];
                secilenLokasyonId = Convert.ToInt32(row.Cells["Id"].Value);
                secilenLokasyon = row.Cells["Havaalani"].Value.ToString();
            }
        }

        private void dgLokasyon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
