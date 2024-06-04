using FluentNHibernate.Mapping;

namespace UcakRezervasyonSistemi
{
    public class Lokasyon
    {
        public virtual long Id { get; set; }
        public virtual string Ulke { get; set; }
        public virtual string Sehir { get; set; }
        public virtual string Havaalani { get; set; }
        public virtual string AcikKapali { get; set; }
    }

    public sealed class LokasyonMap : ClassMap<Lokasyon>
    {
        public LokasyonMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Ulke);
            Map(x => x.Sehir);
            Map(x => x.Havaalani);
            Map(x => x.AcikKapali);
            Table("Lokasyonlar");
        }
    }
}
