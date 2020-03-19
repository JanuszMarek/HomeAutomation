using HomeAutomation.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAutomation.Models.Entities
{
    public class DeviceType : Entity
    {
        [ForeignKey("Category")]
        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Device> Devices { get; set; }

        public static void CreateDatabaseScheme(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.ToTable(nameof(DeviceType), "HA");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Description)
                    .HasMaxLength(500);  

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DeviceTypes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceType_Category");

                entity.Property(e => e.RowVersion).IsRowVersion();
            });
        }
    }
}
