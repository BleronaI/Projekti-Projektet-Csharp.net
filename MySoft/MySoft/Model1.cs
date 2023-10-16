using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MySoft
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DBProduktetContext")
        {
        }

        public virtual DbSet<Kategoria> Kategorias { get; set; }
        public virtual DbSet<Produktet> Produktets { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoria>()
                .Property(e => e.TitulliKategoris)
                .IsUnicode(false);

            modelBuilder.Entity<Produktet>()
                .Property(e => e.Emri)
                .IsUnicode(false);

            modelBuilder.Entity<Produktet>()
                .Property(e => e.Pershkrimi)
                .IsUnicode(false);
        }
    }
}
