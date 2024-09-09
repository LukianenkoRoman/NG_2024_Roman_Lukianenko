using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    public class Storage : IEntity
    {
        public Guid Id { get; set; }
        public string adress { get; set; }

        public int no { get; set; }

        public Guid Director { get; set; }

        public Guid Employer { get; set; }

        [ForeignKey("Director")]
        public Manager manager { get; set; }

        [ForeignKey("Employer")]
        public Employer employer { get; set; }
    }
}