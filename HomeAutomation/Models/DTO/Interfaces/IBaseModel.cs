namespace HomeAutomation.Models.DTO.Interfaces
{
    public interface IBaseModel
    {
        long Id { get; set; }
        string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
