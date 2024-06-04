using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyonSistemi
{
    public partial class RezervasyonForm : Form
    {
        public class RezervasyonBilgileri
        {
            public string MusteriAdi { get; set; }
            public string Cinsiyet { get; set; }
            public string EngelliDurumu { get; set; }
            public DateTime DogumTarihi { get; set; }
            public DateTime RezervasyonTarihi { get; set; }
            public string KoltukNo { get; set; }
        }

        public Ucak ucak;
        public Musteri musteri;
        public Lokasyon lokasyon;

        public long ucakId = -1;
        char ch;
        public RezervasyonForm()
        {
            InitializeComponent();
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {

        }

        private List<Button> buttonList = new List<Button>();
        public int koltukSiraBaslangic = 1;
        void Yenile()
        {
            ch = 'A';
            koltukSiraBaslangic = 1;
            if (ucakId != -1)
            {
                foreach (var btn in buttonList)
                {
                    if (btn is Button button && koltukPanel.Controls.Contains(btn))
                    {
                        koltukPanel.Controls.Remove(btn);
                    }
                }
                buttonList.Clear();
                var sessionFactory = UcakSessionFactory.OpenSession();
                using (var session = sessionFactory.OpenSession())
                {
                    ucak = session.Query<Ucak>().Where(x => x.Id == ucakId).FirstOrDefault();
                    lblLokasyon.Text = ucak.Model;
                    lblTarih.Text = ucak.UcusTarihi.ToString("d-M-yyyy HH:mm");
                    for (int i = 0; i < ucak.KacKisilik / 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Button button = new Button();
                            button.Size = new Size(60, 30);
                            button.Location = new Point(j * 60, i * 30);
                            button.ForeColor = Color.White;
                            button.Text = $"{ch}{koltukSiraBaslangic}";
                            button.Click += new EventHandler(Button_Click);
                            string koltukNumarasi = button.Text;
                            if (ucak.Rezervasyonlar.Any(r => r.KoltukNo == koltukNumarasi))
                            {
                                button.BackColor = Color.Red;
                            }
                            else
                            {
                                button.BackColor = Color.Green;
                            }

                            koltukPanel.Controls.Add(button);
                            buttonList.Add(button);

                            koltukSiraBaslangic++;
                        }
                        koltukSiraBaslangic = 1;
                        ch++;
                    }
                }

            }
            Goster();
        }

        public void Goster()
        {
            if (ucakId != -1)
            {
                var sessionFactory = UcakSessionFactory.OpenSession();
                using (var session = sessionFactory.OpenSession())
                {
                    var rezervasyonlar = session.Query<Rezervasyon>().Where(x => x.Ucak.Id == ucakId).ToList();

                    BindingList<RezervasyonBilgileri> rezervasyonListesi = new BindingList<RezervasyonBilgileri>();

                    foreach (var rezervasyon in rezervasyonlar)
                    {
                        RezervasyonBilgileri rezervasyonBilgisi = new RezervasyonBilgileri
                        {
                            MusteriAdi = rezervasyon.Musteri.AdSoyad,
                            Cinsiyet = rezervasyon.Musteri.Cinsiyet,
                            EngelliDurumu = rezervasyon.Musteri.Engelli,
                            DogumTarihi = DateTime.Parse(rezervasyon.Musteri.DogumTarihi),
                            RezervasyonTarihi = rezervasyon.TarihSaat,
                            KoltukNo = rezervasyon.KoltukNo
                        };
                        rezervasyonListesi.Add(rezervasyonBilgisi);
                    }

                    dataGridView1.DataSource = rezervasyonListesi;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string koltukNumarasi = clickedButton.Text;

            var sessionFactory = UcakSessionFactory.OpenSession();
            Rezervasyon rezervasyon;
            using (var session = sessionFactory.OpenSession())
            {
                rezervasyon = session.Query<Rezervasyon>()
                                     .Where(x => x.Ucak.Id == ucakId && x.KoltukNo == koltukNumarasi)
                                     .FirstOrDefault();

                if (rezervasyon == null)
                {
                    RezervasyonYap form = new RezervasyonYap(ucakId, koltukNumarasi);
                    form.Show();
                    Yenile();
                    Goster();
                }
                else
                {
                    long rezervasyonId = rezervasyon.Id;
                    BindingList<RezervasyonBilgileri> rezervasyonListesi = new BindingList<RezervasyonBilgileri>();

                    RezervasyonBilgileri rezervasyonBilgisi = new RezervasyonBilgileri
                    {
                        MusteriAdi = rezervasyon.Musteri.AdSoyad,
                        Cinsiyet = rezervasyon.Musteri.Cinsiyet,
                        EngelliDurumu = rezervasyon.Musteri.Engelli,
                        DogumTarihi = DateTime.Parse(rezervasyon.Musteri.DogumTarihi),
                        RezervasyonTarihi = rezervasyon.TarihSaat,
                        KoltukNo = rezervasyon.KoltukNo
                    };

                    rezervasyonListesi.Add(rezervasyonBilgisi);

                    dataGridView1.DataSource = rezervasyonListesi;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(new UcakSec(this).ShowDialog() == DialogResult.OK)
            {
                Yenile();
            }
        }

        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LokasyonEkle().ShowDialog();
        }

        private void uçuşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UcusEkle().ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
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

        private void koltukPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
