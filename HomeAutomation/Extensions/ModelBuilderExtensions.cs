using HomeAutomation.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData<T>(this ModelBuilder modelBuilder, IEnumerable<T> dataSeedCollection) where T : Entity
        {
            foreach (var seed in dataSeedCollection)
            {
                modelBuilder.Entity<T>().HasData(seed);
            }
        }
    }
}
