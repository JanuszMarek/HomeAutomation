using HomeAutomation.Models.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HomeAutomation.Models.DTO.Category
{
    public class CategoryUpdateModel : CategoryInputModel, IBaseUpdateModel
    {
        [Required]
        public long Id { get; set; }
    }
}
