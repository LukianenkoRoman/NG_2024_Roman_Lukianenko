using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epic5_Task1.DataLayer.Data.EntitiesConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired();
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.phone);

            builder.Property(x => x.Name)
                .IsRequired();
        }
    }
}
