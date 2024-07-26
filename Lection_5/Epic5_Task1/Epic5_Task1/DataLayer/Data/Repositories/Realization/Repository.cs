using DataLayer.Entities;
using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;
using Epic5_Task1.DataLayer.Data.Infrastucture;
using Epic5_Task1.DataLayer.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Epic5_Task1.DataLayer.Data.Repositories.Realization
{
    public class Repository : IRepository<IEntity> 
    {
        private readonly Task5DbContext _dbContext;

        public Repository(Task5DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEntity> Create(IEntity entity)
        {
            var createdEntity = await _dbContext.Set<IEntity>().AddAsync(entity);
            return createdEntity.Entity;
        }

        public async Task Delete(Guid id)
        {
            var entity = _dbContext.Set<IEntity>().Find(id);
            if (entity != null)
            {
                _dbContext.Set<IEntity>().Remove(entity);
            }
        }

        public async Task<IEntity> Find(Guid id)
        {
            return await _dbContext.Set<IEntity>().FindAsync(id);
        }

        public IQueryable<IEntity> GetAll()
        {
            return _dbContext.Set<IEntity>();
        }

        public async Task<List<IEntity>> GetAllAsync(Expression<Func<IEntity, bool>> expression)
        {
            return await _dbContext.Set<IEntity>().Where(expression).ToListAsync();
        }

        public async Task<IEntity> Update(IEntity entity)
        {
            var updatedEntity = _dbContext.Set<IEntity>().Update(entity);
            return updatedEntity.Entity;
        }
    }
}
