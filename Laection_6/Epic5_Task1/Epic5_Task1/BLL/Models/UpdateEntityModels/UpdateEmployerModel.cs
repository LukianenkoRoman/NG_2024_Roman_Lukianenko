﻿namespace Epic5_Task1.BLL.Models.GetEntityModels
{
    public class UpdateEmployerModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int phone { get; set; }

        public int selery { get; set; }

        public string position { get; set; }

        public Guid? storageId { get; set; }
    }
}
