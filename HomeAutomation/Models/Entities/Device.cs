﻿using HomeAutomation.Models.Abstract;
using HomeAutomation.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace HomeAutomation.Models.Entities
{
    public class Device : BusinessEntity
    {
        public long ProducerId { get; set; }

        public Producer Producer { get; set; }
        
        public long DeviceTypeId { get; set; }

        public DeviceType DeviceType { get; set; }

        public ConnectionEnum Connection { get; set; }

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

                entity.Property(e => e.Connection)
                    .HasConversion(
                        v => v.ToString(),
                        v => !string.IsNullOrEmpty(v) ? (ConnectionEnum)Enum.Parse(typeof(ConnectionEnum), v) : ConnectionEnum.None);
                });
        }
    }
}
