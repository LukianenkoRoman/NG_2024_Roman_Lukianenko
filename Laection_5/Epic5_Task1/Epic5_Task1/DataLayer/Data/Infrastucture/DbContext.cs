using DataLayer.Entities;
using Epic5_Task1.DataLayer.Data.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Epic5_Task1.DataLayer.Data.Infrastucture
{
    public class Task5DbContext : DbContext 
    {
        public Task5DbContext(DbContextOptions<Task5DbContext> options) 
            : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categoryes { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new EmployerConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new StorageConfiguration);
        }
    }
}
