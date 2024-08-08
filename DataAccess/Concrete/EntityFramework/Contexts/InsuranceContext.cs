using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        {
        }

        // Parameterless constructor
        public InsuranceContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Use a default connection string or environment variable
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-B7QHPV5;Database=Anadolu-Sigorta;TrustServerCertificate=True;integrated security=true");

            }
       
        }

        public DbSet<MusteriTable> MusteriTable { get; set; }
    }
}