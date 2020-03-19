using HomeAutomation.Extensions;
using HomeAutomation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Producer> Producers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CreateDatabaseSchema(modelBuilder);
            SeedDatabase(modelBuilder);
        }

        protected void CreateDatabaseSchema(ModelBuilder modelBuilder)
        {
            Producer.CreateDatabaseScheme(modelBuilder);
            Category.CreateDatabaseScheme(modelBuilder);
            DeviceType.CreateDatabaseScheme(modelBuilder);
            Device.CreateDatabaseScheme(modelBuilder);
        }

        protected void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData(DatabaseSeed.ProducersSeed());
            modelBuilder.SeedData(DatabaseSeed.CategoriesSeed());
        }
    }
}
