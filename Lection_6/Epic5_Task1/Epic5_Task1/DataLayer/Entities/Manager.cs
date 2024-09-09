namespace DataLayer.Entities
{
    public class Manager : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid employerId { get; set; }
    }
}
