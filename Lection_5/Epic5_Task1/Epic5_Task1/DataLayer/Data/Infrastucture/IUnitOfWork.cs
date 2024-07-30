using DataLayer.Entities;
using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;


namespace Epic5_Task1.DataLayer.Data.Infrastucture
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IClientRepository ClientRepository { get; }
        IEmployerRepository EmployerRepository { get; }
        IItemRepository ItemRepository { get; }
        IManagerRepository ManagerRepository { get; }
        IStorageRepository StorageRepository { get; }

        Task SaveChangesAsync();
    }
}
