using HomeAutomation.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HomeAutomation.Models.Entities
{
    public class Category : BusinessEntity
    {
        public ICollection<DeviceType> DeviceTypes { get; set; }

        public static void CreateDatabaseScheme(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable(nameof(Category), "HA");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Description)
                    .HasMaxLength(500);

                entity.Property(e => e.RowVersion).IsRowVersion();
            });
        }
    }
}
