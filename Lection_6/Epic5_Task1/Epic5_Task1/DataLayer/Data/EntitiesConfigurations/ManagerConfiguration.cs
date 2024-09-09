using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epic5_Task1.DataLayer.Data.EntitiesConfigurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired();
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired();
        }
    }
}
