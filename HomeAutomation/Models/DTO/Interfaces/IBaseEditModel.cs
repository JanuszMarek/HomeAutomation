using HomeAutomation.Models.Abstract.Interfaces;

namespace HomeAutomation.Models.DTO.Interfaces
{
    public interface IBaseEditModel : IBaseModel, IBaseCreateModel, IConcurrency
    {
    }
}
