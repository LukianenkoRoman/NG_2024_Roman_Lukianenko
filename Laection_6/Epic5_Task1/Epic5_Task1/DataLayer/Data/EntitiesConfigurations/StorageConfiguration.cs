using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epic5_Task1.DataLayer.Data.EntitiesConfigurations
{
    public class StorageConfiguration : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired();
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.adress)
               .IsRequired()
               .HasMaxLength(250);

            builder.Property(x => x.no)
               .IsRequired()
               .HasMaxLength(100);

            builder
                .HasOne(x => x.directorId)
                .WithOne(x => x.Manager)
                .HasForeignKey(x => x.StorageId);
        }
    }
}
