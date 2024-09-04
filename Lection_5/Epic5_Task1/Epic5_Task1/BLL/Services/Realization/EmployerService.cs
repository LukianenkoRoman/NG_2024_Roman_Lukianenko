using AutoMapper;
using DataLayer.Entities;
using Epic5_Task1.BLL.Models.GetEntityModels;
using Epic5_Task1.BLL.Services.Interfaces;
using Epic5_Task1.DataLayer.Data.Infrastucture;
using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;
using NuGet.Protocol.Plugins;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Epic5_Task1.BLL.Services.Realization
{
    public class EmployerService : IEmployerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public async Task<Guid> AddAsync(EmployerReadModel model)
        {
            var employerRepository = _unitOfWork.EmployerRepository;
            var storageRepositry = _unitOfWork.StorageRepository;

            var employer = _mapper.Map<Employer>(model);


            if (model is not null && model.storageId.HasValue)
            {
                var existingStorage = await employerRepository.Find(model.storageId.Value);
                employer.Name = existingStorage;
            }

            var result = await employerRepository.Create(employer);
            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var employerRepository = _unitOfWork.EmployerRepository;
            await employerRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployerReadModel>> GetAllAsync()
        {
            var employerRepository = _unitOfWork.EmployerRepository;
            return _mapper.Map<IEnumerable<EmployerReadModel>>(employerRepository.GetAll());
        }

        public async Task<Guid> UpdateAsync(UpdateEmployerModel model)
        {
            var employerRepository = _unitOfWork.EmployerRepository;
            var employer = await employerRepository.Find(model.Id);

            _mapper.Map(model, employer);

            var result = await employerRepository.Update(employer);

            await _unitOfWork.SaveChangesAsync();

            return result.Id;
        }

        public async Task<EmployerReadModel> GetEmployerAsync(Guid storageId)
        {
            var employerRepository = _unitOfWork.EmployerRepository;
            var employer = employerRepository.Find(storageId);
            return _mapper.Map<EmployerReadModel>(employer);
        }
    }
}
