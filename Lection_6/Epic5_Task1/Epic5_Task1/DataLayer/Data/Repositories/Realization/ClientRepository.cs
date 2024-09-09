using DataLayer.Entities;
using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;
using Epic5_Task1.DataLayer.Data.Infrastucture;
using Epic5_Task1.DataLayer.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Epic5_Task1.DataLayer.Data.Repositories.Realization;

namespace Epic5_Task1.DataLayer.Data.Repositories.Interfaces
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(Task5DbContext dbContext) : base(dbContext)
        {
        }
    }
}
