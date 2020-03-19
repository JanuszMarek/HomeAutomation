using HomeAutomation.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Models.Entities
{
    public class Device : Entity
    {
        public decimal Price { get; set; }

        public long ProducerId { get; set; }

        public Producer Producer { get; set; }
        
        public long DeviceTypeId { get; set; }

        public DeviceType DeviceType { get; set; }

        public static void CreateDatabaseScheme(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable(nameof(Device), "HA");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Description)
                    .HasMaxLength(500);

                entity.HasOne(d => d.Producer)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.ProducerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Device_Producer");

                entity.HasOne(d => d.DeviceType)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.DeviceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Device_DeviceType");

                entity.Property(e => e.RowVersion).IsRowVersion();
            });
        }
    }
}
