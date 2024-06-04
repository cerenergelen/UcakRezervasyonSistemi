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
    public partial class UcusEkle : Form
    {
        public long secilenLokasyonId = -1;
        public string secilenLokasyon;
        public UcusEkle()
        {
            InitializeComponent();
        }

        private void UcusEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LokasyonSec(this).ShowDialog();
            btnSec.Text = secilenLokasyon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbModel.Text != "" && secilenLokasyonId != -1 && tbSeriNo.Text != "" && numericKisiSayisi.Value > 50)
            {
                try
                {
                    var sessionFactory = UcakSessionFactory.OpenSession();

                    using (var session = sessionFactory.OpenSession())
                    {
                        Ucak data = new Ucak
                        {
                            Model = tbModel.Text,
                            SeriNo = tbSeriNo.Text,
                            KacKisilik = Convert.ToInt64(numericKisiSayisi.Value),
                            BakimTarihi = dtBakimTarihi.Value,
                            UcusTarihi = dateTimePicker1.Value,
                            Lokasyon = session.Get<Lokasyon>(secilenLokasyonId)
                        };

                        session.Save(data);
                        session.Flush();
                        MessageBox.Show("Uçak başarıyla eklendi.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Tüm değerleri giriniz.");
            }
        }
    }
}
