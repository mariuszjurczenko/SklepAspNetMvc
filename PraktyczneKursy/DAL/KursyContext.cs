using Microsoft.AspNet.Identity.EntityFramework;
using PraktyczneKursy.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PraktyczneKursy.DAL
{
    public class KursyContext : IdentityDbContext<ApplicationUser>
    {
        public KursyContext() : base("KursyContext")
        {
        }

        static KursyContext()
        {
            Database.SetInitializer<KursyContext>(new KursyInitializer());
        }

        public static KursyContext Create()
        {
            return new KursyContext();
        }

        public virtual DbSet<Kurs> Kursy { get; set; }
        public virtual DbSet<Kategoria> Kategorie { get; set; }
        public virtual DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // using System.Data.Entity.ModelConfiguration.Conventions;
            // Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            // Zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}