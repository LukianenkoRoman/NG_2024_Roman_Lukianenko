namespace Epic5_Task1.BLL.Models.GetEntityModels
{
    public class ItemReadModel
    {
        public Guid Id { get; set; }
        public Guid senderId { get; set; }
        public Guid reciverId { get; set; }

        public int weight { get; set; }

        public string description { get; set; }
        public Guid? storageId { get; set; }
    }
}
