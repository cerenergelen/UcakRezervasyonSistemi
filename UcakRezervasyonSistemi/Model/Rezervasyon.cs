using FluentNHibernate.Mapping;
using System;

namespace UcakRezervasyonSistemi
{
    public class Rezervasyon
    {
        public virtual long Id { get; set; }
        public virtual DateTime TarihSaat { get; set; }
        public virtual string KoltukNo { get; set; }
        public virtual bool AcikKapali { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Ucak Ucak { get; set; }
    }

    public sealed class RezervasyonMap : ClassMap<Rezervasyon>
    {
        public RezervasyonMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.TarihSaat);
            Map(x => x.KoltukNo);
            Map(x => x.AcikKapali);
            References(x => x.Musteri);
            References(x => x.Ucak);
            Table("Rezervasyonlar");
        }
    }
}
