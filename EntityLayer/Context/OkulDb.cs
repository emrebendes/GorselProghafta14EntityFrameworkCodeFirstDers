using EntityLayer.Entity;
using EntityLayer.Entity.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Context
{
    public class OkulDb : DbContext
    {
        public OkulDb():base("name=bizimBaglanti")
        {
            //Database.SetInitializer<OkulDb>(new DropCreateDatabaseIfModelChanges<OkulDb>());

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OgrenciMap());
            modelBuilder.Configurations.Add(new BolumMap());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Bolum> bolumler { get; set; }
        public DbSet<Ogrenci> ogrenciler { get; set; }
    }
}
