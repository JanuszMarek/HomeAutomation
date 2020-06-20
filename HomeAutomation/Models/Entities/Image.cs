using HomeAutomation.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System;

namespace HomeAutomation.Models.Entities
{
    public class Image: Entity
    {
        public string FilePath { get; set; }

        public Image()
        {
        }

        public static void CreateDatabaseScheme(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable(nameof(Image), "HA");

                entity.Property(e => e.RowVersion).IsRowVersion();
            });
        }
    }
}
