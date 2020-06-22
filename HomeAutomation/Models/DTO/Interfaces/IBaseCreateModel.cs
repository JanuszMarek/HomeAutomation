namespace HomeAutomation.Models.DTO.Interfaces
{
    public interface IBaseCreateModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ImageId { get; set; }
    }
}
