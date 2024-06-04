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
    public partial class LokasyonEkle : Form
    {
        public LokasyonEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbAcikmi.SelectedIndex >= 0 && tbHavaalani.Text != "" && tbSehir.Text != "" && tbUlke.Text != "")
            {
                try
                {
                    var sessionFactory = UcakSessionFactory.OpenSession();

                    using (var session = sessionFactory.OpenSession())
                    {
                        Lokasyon data = new Lokasyon
                        {
                            Ulke = tbUlke.Text,
                            Sehir = tbSehir.Text,
                            Havaalani = tbHavaalani.Text,
                            AcikKapali = cbAcikmi.SelectedItem.ToString()
                        };
                        session.Save(data);
                        session.Flush();
                        MessageBox.Show("Kayıt başarılı");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Tüm değerleri giriniz.");
        }
    }
}
