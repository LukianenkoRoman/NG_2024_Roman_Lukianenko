using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    public class Item : IEntity
    {
        public Guid Id { get; set; }
        public int senderId { get; set; }
        public int reciverId { get; set; }

        public int weight { get; set; }

        public ICollection<Category> description{ get; set; }
        public int storageId { get; set; }

        [ForeignKey("storageId")]
        public Storage Storage { get; set; }

        [ForeignKey("description")]
        public Category Category { get; set; }
    }
}