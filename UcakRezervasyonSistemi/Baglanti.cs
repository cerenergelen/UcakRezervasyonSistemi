using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyonSistemi
{
    public static class Baglanti
    {
        public static readonly string ConnectionString = $"Data Source={Application.StartupPath}\\UcakRezervasyon.db;Version=3;";
    }
}
