using FluentNHibernate.Mapping;
using System.Collections.Generic;
using System;

namespace UcakRezervasyonSistemi
{
    public class Ucak
    {
        public virtual long Id { get; set; }
        public virtual string Model { get; set; }
        public virtual string SeriNo { get; set; }
        public virtual DateTime BakimTarihi { get; set; }
        public virtual DateTime UcusTarihi { get; set; }
        public virtual long KacKisilik { get; set; }
        public virtual Lokasyon Lokasyon { get; set; }
        public virtual IList<Rezervasyon> Rezervasyonlar { get; set; }
    }

    public sealed class UcakMap : ClassMap<Ucak>
    {
        public UcakMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Model);
            Map(x => x.SeriNo);
            Map(x => x.BakimTarihi);
            Map(x => x.KacKisilik);
            Map(x => x.UcusTarihi);
            References(x => x.Lokasyon).Column("LokasyonId");
            HasMany(x => x.Rezervasyonlar).Cascade.All();
            Table("Ucaklar");
        }
    }

}
