﻿// <auto-generated />
using AspNetCoreAPI_Intro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreAPI_Intro.Migrations
{
    [DbContext(typeof(CityDbContext))]
    partial class CityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCoreAPI_Intro.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "34",
                            CountryId = 1,
                            Name = "İstanbul",
                            Region = "Marmara"
                        },
                        new
                        {
                            Id = 2,
                            Code = "35",
                            CountryId = 1,
                            Name = "İzmir",
                            Region = "Ege"
                        },
                        new
                        {
                            Id = 3,
                            Code = "06",
                            CountryId = 1,
                            Name = "Ankara",
                            Region = "İç Anadolu"
                        },
                        new
                        {
                            Id = 4,
                            Code = "07",
                            CountryId = 1,
                            Name = "Antalya",
                            Region = "Akdeniz"
                        },
                        new
                        {
                            Id = 5,
                            Code = "16",
                            CountryId = 1,
                            Name = "Bursa",
                            Region = "Marmara"
                        },
                        new
                        {
                            Id = 6,
                            Code = "52",
                            CountryId = 1,
                            Name = "Ordu",
                            Region = "Karadeniz"
                        });
                });

            modelBuilder.Entity("AspNetCoreAPI_Intro.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Türkiye"
                        });
                });

            modelBuilder.Entity("AspNetCoreAPI_Intro.Entities.City", b =>
                {
                    b.HasOne("AspNetCoreAPI_Intro.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("AspNetCoreAPI_Intro.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
