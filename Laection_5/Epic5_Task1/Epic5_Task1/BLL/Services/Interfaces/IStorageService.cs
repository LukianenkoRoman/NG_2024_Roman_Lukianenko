using Epic5_Task1.BLL.Models.GetEntityModels;

namespace Epic5_Task1.BLL.Services.Interfaces
{
    public interface IStorageService
    {
        Task<IEnumerable<StorageReadModel>> GetAllAsync();
        Task<Guid> AddAsync(StorageReadModel model);
        Task<Guid> UpdateAsync(UpdateStorageModel model);
        Task DeleteAsync(Guid id);

        Task<IEnumerable<StorageReadModel>> GetStorageIdAsync(Guid Id);
        Task<IEnumerable<StorageReadModel>> GetManagerAsync(Guid directorId);
    }
}
