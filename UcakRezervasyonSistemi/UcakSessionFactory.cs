using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using UcakRezervasyonSistemi;

namespace UcakRezervasyonSistemi
{
    public static class UcakSessionFactory
    {
        public static ISessionFactory OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                    .ConnectionString(Baglanti.ConnectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<RezervasyonMap>()) 
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                    .Create(false, false))
                .BuildSessionFactory();
                        return sessionFactory;


        }
    }
}
