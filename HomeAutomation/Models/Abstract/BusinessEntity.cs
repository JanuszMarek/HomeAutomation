using HomeAutomation.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models.Abstract
{
    public class BusinessEntity : Entity, IBusinessEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(UploadedImage))]
        public long? UploadedImageId { get; set; }
        public UploadedImage UploadedImage { get; set; }
    }
}
