using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epic5_Task1.DataLayer.Data.EntitiesConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired();
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.description)
               .IsRequired()
               .HasMaxLength(250);
        }
    }
}
