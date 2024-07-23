using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epic5_Task1.DataLayer.Data.EntitiesConfigurations
{
    public class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired();
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.phone);

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.selery)
                .IsRequired();

            builder.Property(x => x.position)
                .IsRequired();

            builder
                .HasOne(x => x.storageId)
                .WithOne(x => x.storageId)
                .HasForeignKey(x => x.StorageId);
        }
    }
}
