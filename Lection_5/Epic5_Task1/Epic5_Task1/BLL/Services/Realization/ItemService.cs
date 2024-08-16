using AutoMapper;
using DataLayer.Entities;
using Epic5_Task1.BLL.Models.GetEntityModels;
using Epic5_Task1.BLL.Services.Interfaces;
using Epic5_Task1.DataLayer.Data.Infrastucture;
using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;

namespace Epic5_Task1.BLL.Services.Realization
{
    public class ItemService : IItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ItemService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> AddAsync(ItemReadModel model)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            var categoryRepository = _unitOfWork.CategoryRepository;
            var clientRepository = _unitOfWork.ClientRepository;
            var storageRepositry = _unitOfWork.StorageRepository;

            var item = _mapper.Map<Item>(model);

            if (model.description is not null && model.description.Any())
            {
                var existingDescription = await categoryRepository.GetAllAsync(x => model.description.Contains(x.Id));
                item.description = existingDescription;
            }

            if (model is not null && model.reciverId.HasValue)
            {
                var existingReciver = await clientRepository.Find(model.reciverId.Value);
                item.reciverId = existingReciver;
            }

            if(model is not null && model.senderId.HasValue)
            {
                var existingSender = await clientRepository.Find(model.senderId.Value);
                item.senderId = existingSender;
            }

            if (model is not null && model.storageId.HasValue)
            {
                var existingStorage = await storageRepositry.Find(model.storageId.Value);
                item.senderId = existingStorage;
            }

            var result = await itemRepository.Create(item);
            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            await itemRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<ItemReadModel>> GetAllAsync()
        {
            var itemRepository = _unitOfWork.ItemRepository;
            return _mapper.Map<IEnumerable<ItemReadModel>>(itemRepository.GetAll());
        }

        public async Task<Guid> UpdateAsync(UpdateItemModel model)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            var item = await itemRepository.Find(model.ItemId);

            _mapper.Map(model, item);

            await UpdateItems(model.description, item);
            var result = await itemRepository.Update(item);

            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        private async Task UpdateItems(List<Guid> updateCategorysList, Item item)
        {
            var categoryRepository = _unitOfWork.CategoryRepository;
            var descriptionId = item.description.Select(description => description.Id);

            var existingCategory = await categoryRepository.GetAllAsync(x => descriptionId.Contains(x.Id));

            var categorysToAdd = updateCategorysList.Except(existingCategory.Select(item => item.Id)).ToList();

            var categorysToRemove = existingCategory.Where(x => !updateCategorysList.Contains(x.Id)).ToList();

            foreach (var description in categorysToAdd)
            {
                var categoryToAdd = await categoryRepository.Find(description);
                item.description.Add(categoryToAdd);
            }

            foreach (var description in categorysToRemove)
            {
                item.description.Remove(description);
            }
        }

        public async Task<ItemReadModel> GetByIdAsync(Guid id)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            var item = itemRepository.Find(id);
            return _mapper.Map<ItemReadModel>(item);
        }

        public async Task<ItemReadModel> GetBySenderAsync(Guid senderId)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            var item = itemRepository.Find(senderId);
            return _mapper.Map<ItemReadModel>(item);
        }

        public async Task<ItemReadModel> GetByReciverAsync(Guid reciverId)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            var item = itemRepository.Find(reciverId);
            return _mapper.Map<ItemReadModel>(item);
        }

        public async Task<ItemReadModel> GetByStorageAsync(Guid storageId)
        {
            var itemRepository = _unitOfWork.ItemRepository;
            var item = itemRepository.Find(storageId);
            return _mapper.Map<ItemReadModel>(item);
        }

    }
}
