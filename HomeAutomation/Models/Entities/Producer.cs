using HomeAutomation.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HomeAutomation.Models.Entities
{
    public class Producer : Entity
    {
        public ICollection<Device> Devices { get; set; }

        public static void CreateDatabaseScheme(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producer>(entity =>
            {
                entity.ToTable(nameof(Producer), "HA");

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
