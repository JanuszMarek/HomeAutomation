using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Abstract
{
    public class BaseEditModel : BaseCreateModel, IBaseEditModel
    {
        [Required]
        public long Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string ImageUrl { get; set; }
    }
}
