using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    public class Employer : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int phone { get; set; }

        public int selery { get; set; }

        public string position { get; set; }

        public int storageId { get; set; }

        [ForeignKey("storageId")]
        public Storage Storage { get; set; }
    }
}