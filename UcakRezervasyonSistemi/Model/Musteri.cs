using FluentNHibernate.Mapping;

namespace UcakRezervasyonSistemi
{
    public class Musteri
    {
        public virtual long Id { get; set; }
        public virtual string AdSoyad { get; set; }
        public virtual string Cinsiyet { get; set; }
        public virtual long Yas { get; set; }
        public virtual string Yasli { get; set; }
        public virtual string Engelli { get; set; }
        public virtual string DogumTarihi { get; set; }
    }

    public sealed class MusteriMap : ClassMap<Musteri>
    {
        public MusteriMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.AdSoyad);
            Map(x => x.Cinsiyet);
            Map(x => x.Yas);
            Map(x => x.Yasli);
            Map(x => x.Engelli);
            Map(x => x.DogumTarihi);
            Table("Musteriler");
        }
    }
}
