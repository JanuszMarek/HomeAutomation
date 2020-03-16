using HomeAutomation.Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.DTO.Category
{
    public class CategoryListingModel : IBaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}