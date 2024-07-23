using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epic5_Task1.DataLayer.Data.EntitiesConfigurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired();
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.reciverId)
                .IsRequired();
            builder.HasIndex(x => x.reciverId);

            builder.Property(x => x.senderId)
               .IsRequired();
            builder.HasIndex(x => x.senderId);

            builder.Property(x => x.weight)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(x => x.description)
               .IsRequired()
               .HasMaxLength(250);

            builder
                .HasOne(x => x.description)
                .WithMany(x => x.Category)
                .HasForeignKey(x => x.description);

            builder
                .HasOne(x => x.storageId)
                .WithOne(x => x.Storage)
                .HasForeignKey(x => x.StorageId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
