﻿using Epic5_Task1.BLL.Models.GetEntityModels;

namespace Epic5_Task1.BLL.Services.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<ItemReadModel>> GetAllAsync();
        Task<Guid> AddAsync(ItemReadModel model);
        Task<Guid> UpdateAsync(UpdateItemModel model);
        Task DeleteAsync(Guid id);
        Task<ItemReadModel> GetByIdAsync(Guid id);
        Task<ItemReadModel> GetBySenderAsync(Guid senderId);
        Task<ItemReadModel> GetByReciverAsync(Guid reciverId);
        Task<ItemReadModel> GetByStorageAsync(Guid storageId);
        Task<IEnumerable<ItemModel>> GetByDescriptionAsync(string description, Guid weight, int minWeight, int maxWeight);
    }
}
