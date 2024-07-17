namespace DataLayer.Entities
{
    public class Category : IEntity
    {
        public Guid Id { get; set; }
        public string description { get; set; }
    }
}
