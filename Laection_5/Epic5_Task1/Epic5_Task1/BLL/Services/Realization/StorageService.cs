using AutoMapper;
using DataLayer.Entities;
using Epic5_Task1.BLL.Models.GetEntityModels;
using Epic5_Task1.BLL.Services.Interfaces;
using Epic5_Task1.DataLayer.Data.Infrastucture;
using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Epic5_Task1.BLL.Services.Realization
{
    public class StorageService : IStorageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StorageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> AddAsync(StorageReadModel model)
        {
            var storageRepositry = _unitOfWork.StorageRepository;
            var employerRepository = _unitOfWork.EmployerRepository;
            var managerRepository = _unitOfWork.ManagerRepository;

            var storage = _mapper.Map<Storage>(model);

            if (model is not null && model.employerId.HasValue)
            {
                var existingEmployer = await employerRepository.Find(model.employerId.Value);
                storage.Employer = existingEmployer;
            }

            if (model is not null && model.directorId.HasValue)
            {
                var existingDirector = await managerRepository.Find(model.directorId.Value);
                storage.Director = existingDirector;
            }

            var result = await storageRepositry.Create(storage);
            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var storageRepository = _unitOfWork.StorageRepository;
            await storageRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<StorageReadModel>> GetAllAsync()
        {
            var storageRepository = _unitOfWork.StorageRepository;
            return _mapper.Map<IEnumerable<StorageReadModel>>(storageRepository.GetAll());
        }

        public async Task<Guid> UpdateAsync(UpdateStorageModel model)
        {
            var storageRepository = _unitOfWork.StorageRepository;
            var storage = await storageRepository.Find(model.Id);

            _mapper.Map(model, storage);

            var result = await storageRepository.Update(storage);

            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        public async Task<IEnumerable<StorageReadModel>> GetManagerAsync(Guid directorId)
        {
            var storageRepository = _unitOfWork.StorageRepository;
            var manager = storageRepository.Find(directorId);

            return _mapper.Map<IEnumerable<StorageReadModel>>(manager);
        }

        public async Task<IEnumerable<StorageReadModel>> GetStorageIdAsync(Guid Id)
        {
            var storageRepository = _unitOfWork.StorageRepository;
            var storage = storageRepository.Find(Id);

            return _mapper.Map<IEnumerable<StorageReadModel>>(storage);
        }
    }
}
