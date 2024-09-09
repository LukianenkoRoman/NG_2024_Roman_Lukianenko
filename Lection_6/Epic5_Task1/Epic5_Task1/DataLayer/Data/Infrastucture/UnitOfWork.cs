using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;

namespace Epic5_Task1.DataLayer.Data.Infrastucture
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Task5DbContext _dbContext;
        ICategoryRepository CategoryRepository { get; }
        IClientRepository ClientRepository { get; }
        IEmployerRepository EmployerRepository { get; }
        IItemRepository ItemRepository { get; }
        IManagerRepository ManagerRepository { get; }
        IStorageRepository StorageRepository { get; }
    
        public UnitOfWork(
            Task5DbContext dbContext, 
            ICategoryRepository categoryRepository, 
            IClientRepository clientRepository, 
            IEmployerRepository employerRepository, 
            IItemRepository itemRepository, 
            IManagerRepository managerRepository, 
            IStorageRepository storageRepository)
        {
            _dbContext = dbContext;
            CategoryRepository = categoryRepository;
            ClientRepository = clientRepository;
            EmployerRepository = employerRepository;
            ItemRepository = itemRepository;
            ManagerRepository = managerRepository;
            StorageRepository = storageRepository;
        }
    }
}
