using Epic5_Task1.BLL.Models.GetEntityModels;

namespace Epic5_Task1.BLL.Services.Interfaces
{
    public interface IEmployerService
    {
        Task<IEnumerable<EmployerReadModel>> GetAllAsync();
        Task<Guid> AddAsync(EmployerReadModel model);
        Task<Guid> UpdateAsync(UpdateEmployerModel model);
        Task DeleteAsync(Guid id);

        Task<EmployerReadModel> GetEmployerAsync(Guid sttorageId);
    }
}
