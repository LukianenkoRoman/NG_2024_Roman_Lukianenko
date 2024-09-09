using Epic5_Task1.DataLayer.Data.Infrastucture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections;

namespace Epic5_Task1.DataLayer.Migrations
{
    [DbContext(typeof(Task5DbContext))]
    public class Task6DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable

            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataLayer.Entities.Item", b =>
            {
                b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");
                
                b.Property<int>("Weight")
                        .HasColumnType("int")
                        .IsRequired();
                
                b.Property<string>("description")
                        .HasColumnType("string")
                        .IsRequired();

                b.Property<Guid>("senderId")
                        .HasColumnType("uniqueidentifier");

                b.Property<Guid>("reciverId")
                        .HasColumnType("uniqueidentifier");

                b.Property<Guid>("storageId")
                        .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("Items");
            });

            modelBuilder.Entity("DataLayer.Entities.Category", b =>
            {
                b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                b.Property<string>("description")
                        .HasColumnType("string")
                        .IsRequired();

                b.HasKey ("Id");

                b.ToTable("Categoryes");
            });

            modelBuilder.Entity("DataLayer.Entities.Storage", b =>
            {
                b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                b.Property<string>("adress")
                        .HasColumnType("string")
                        .IsRequired();

                b.Property<int>("no")
                        .HasColumnType("int")
                        .IsRequired();

                b.Property<Guid>("Director")
                        .HasColumnType("uniqueidentifier");

                b.Property<Guid>("Employer")
                        .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("Storagess");
            });

            modelBuilder.Entity("DataLayer.Entities.Client", b => 
            {
                b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                b.Property<string>("Nmae")
                        .HasColumnType("string")
                        .IsRequired();

                b.Property<int>("phone")
                        .HasColumnType("int")
                        .IsRequired();

                b.HasKey("Id");

                b.ToTable("Clients");
            });

            modelBuilder.Entity("DataLayer.Entities.Employer", b =>
            {
                b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                b.Property<string>("Nmae")
                        .HasColumnType("string")
                        .IsRequired();

                b.Property<int>("phone")
                        .HasColumnType("int")
                        .IsRequired();

                b.Property<int>("selery")
                        .HasColumnType("int")
                        .IsRequired();

                b.Property<string>("position")
                        .HasColumnType("string")
                        .IsRequired();

                b.Property<Guid>("storageId")
                        .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("Employers");
            });

            modelBuilder.Entity("DataLayer.Entities.Manager", b => 
            {
                b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                b.Property<string>("Nmae")
                        .HasColumnType("string")
                        .IsRequired();

                b.Property<Guid>("storageId")
                        .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("Managers");
            });
        }
    }
}
