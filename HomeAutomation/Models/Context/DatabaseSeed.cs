using HomeAutomation.Models.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.Context
{
    public static class DatabaseSeed
    {
        public static IEnumerable<Producer> ProducersSeed()
        {
            var collection = new List<Producer>()
            {
                new Producer(){Id = 1, Name = "Xiaomi", Description = "Xiaomi Najlepsze"},
                new Producer(){Id = 2, Name = "Xiaomi Aqara", Description = "Xiaomi Najlepsze"},
                new Producer(){Id = 3, Name = "Xiaomi Mija", Description = "Xiaomi Najlepsze"},
                new Producer(){Id = 4, Name = "Sonoff", Description = "SONOFF was founded out of a simple need: make your lives easier, smart and better. we’ve the ambition to design and create the most innovative smart products with a simple and affordable way to give you a smarter home."},
            };

            collection.ForEach(item =>
            {
                item.CreateDate = new DateTime(2020, 01, 01);
                item.UpdateDate = new DateTime(2020, 01, 01);
            });

            return collection;
        }

        public static IEnumerable<Category> CategoriesSeed()
        {
            var collection = new List<Category>()
            {
                new Category(){Id = 1, Name = "Oświetlenie", Description = "Możesz zarówno sterować oświetleniem jak również uruchomić schematy automatycznego włączania lub wyłączania poszczególnych punktów oświetlenia w zależności detekcji określonego zjawiska."},
                new Category(){Id = 2, Name = "Rozrywka", Description = "TV, Audio"},
                new Category(){Id = 3, Name = "Bezpieczeństwo", Description = "Kamerki, sensory"},
                new Category(){Id = 4, Name = "Komfort", Description = "Oczyszczacze, nawilżacze, odkurzacze"},
            };

            collection.ForEach(item =>
            {
                item.CreateDate = new DateTime(2020, 01, 01);
                item.UpdateDate = new DateTime(2020, 01, 01);
            });

            return collection;
        }
    }
}
