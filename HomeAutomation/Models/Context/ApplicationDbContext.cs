using HomeAutomation.Extensions;
using HomeAutomation.Models.Abstract.Interfaces;
using HomeAutomation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateConcurrency();
            SetCreateUpdateDate();

            return await base.SaveChangesAsync(cancellationToken);
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

        private void ValidateConcurrency()
        {
            var changedConcurrencyEntries = ChangeTracker.Entries()
                .Where(x => (x.State == EntityState.Modified || x.State == EntityState.Deleted) && (x.Entity is IConcurrency) == true);

            foreach (var entry in changedConcurrencyEntries)
            {
                var rowVersion = (entry.Entity as IConcurrency).RowVersion;
                var originalValues = (byte[])entry.OriginalValues["RowVersion"];

                if (originalValues != null && rowVersion == null)
                {
                    throw new Exception("RowVersion cannot be null.");
                }

                if (originalValues != null && !rowVersion.SequenceEqual(originalValues))
                {
                    throw new Exception("RowVersion is older than in Database.");
                }
            }
        }

		public virtual void SetCreateUpdateDate()
		{
			var changedEntries = ChangeTracker
					.Entries()
					.Where(x => (x.State == EntityState.Modified || x.State == EntityState.Modified) && x.Entity is IConcurrency);

			if (changedEntries.Count() > 0)
			{
				foreach (var entry in changedEntries)
				{
					if (entry.Entity is IConcurrency && entry.State == EntityState.Modified)
					{
						entry.CurrentValues[nameof(IConcurrency.UpdateDate)] = DateTime.Now;
					}
                    if (entry.Entity is IConcurrency && entry.State == EntityState.Added)
                    {
                        entry.CurrentValues[nameof(IConcurrency.CreateDate)] = DateTime.UtcNow;
                        entry.CurrentValues[nameof(IConcurrency.CreateDate)] = entry.CurrentValues[nameof(IConcurrency.CreateDate)];
                    }
                }
			}
		}
	}
}
