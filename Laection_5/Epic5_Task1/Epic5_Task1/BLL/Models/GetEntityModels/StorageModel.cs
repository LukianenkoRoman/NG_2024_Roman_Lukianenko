namespace Epic5_Task1.BLL.Models.GetEntityModels
{
    public class StorageModel
    {
        public Guid Id { get; set; }
        public string adress { get; set; }

        public int no { get; set; }

        public Guid directorId { get; set; }

        public Guid employerId { get; set; }
    }
}
