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
    public partial class RezervasyonYap : Form
    {
        long ucakId;
        string koltukno;
        public RezervasyonYap(long ucakId,string koltukno)
        {
            InitializeComponent();
            this.ucakId= ucakId;
            this.koltukno = koltukno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sessionFactory = UcakSessionFactory.OpenSession();

                using (var session = sessionFactory.OpenSession())
                {
                    Musteri musteri = new Musteri
                    {
                        AdSoyad = tbAd.Text,
                        DogumTarihi = dateTimePicker1.Value.ToString(),
                        Yasli = comboBox1.SelectedItem.ToString(),
                        Engelli = comboBox2.SelectedItem.ToString(),
                        Cinsiyet = comboBox3.SelectedItem.ToString(),
                    };

                    Ucak ucak = session.Get<Ucak>(ucakId);
                    string koltukNumarasi = koltukno;

                    Rezervasyon rezervasyon = new Rezervasyon
                    {
                        Musteri = musteri,
                        KoltukNo = koltukNumarasi,
                        TarihSaat = DateTime.Now,
                        AcikKapali = true,
                        Ucak = ucak
                    };

                    ucak.Rezervasyonlar.Add(rezervasyon);

                    session.Save(musteri);
                    session.Save(rezervasyon);
                    session.Update(ucak);
                    session.Flush();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Kayıt başarılı");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
