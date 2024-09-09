using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    public class Storage : IEntity
    {
        public Guid Id { get; set; }
        public string adress { get; set; }

        public int no { get; set; }

        public int directorId { get; set; }

        [ForeignKey("directorId")]
        public Manager manager { get; set; }
    }
}