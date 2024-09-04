namespace DataLayer.Entities
{
    public class Client : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int phone { get; set; }
    }
}
