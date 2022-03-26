﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Configurations;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(PersistenceDbContext))]
    partial class PersistenceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Accommodation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Accommodations");
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a6ad2fe-6318-454f-907e-a67b0893537a"),
                            Name = "Cidade N"
                        },
                        new
                        {
                            Id = new Guid("0a6bd2fe-6318-454f-907e-b67b0893537a"),
                            Name = "Cidade S"
                        },
                        new
                        {
                            Id = new Guid("0a6cd2fe-6318-454f-907e-c67b0893537a"),
                            Name = "Cidade L"
                        },
                        new
                        {
                            Id = new Guid("0a6dd2fe-6318-454f-907e-d67b0893537a"),
                            Name = "Cidade O"
                        });
                });

            modelBuilder.Entity("Domain.Entities.School", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<Guid>("CityId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Domain.Entities.Accommodation", b =>
                {
                    b.OwnsMany("Domain.Entities.Address", "Addresses", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<long>("AccommodationId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Complement")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.Property<string>("District")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.HasKey("Id");

                            b1.HasIndex("AccommodationId");

                            b1.ToTable("Address");

                            b1.WithOwner()
                                .HasForeignKey("AccommodationId");
                        });

                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.OwnsMany("Domain.Entities.CityAccommodation", "CityAccommodations", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<long>("AccommodationId")
                                .HasColumnType("bigint");

                            b1.Property<Guid>("CityId")
                                .HasColumnType("char(36)");

                            b1.HasKey("Id");

                            b1.HasIndex("AccommodationId");

                            b1.HasIndex("CityId");

                            b1.ToTable("CityAccommodation");

                            b1.HasOne("Domain.Entities.Accommodation", "Accommodation")
                                .WithMany()
                                .HasForeignKey("AccommodationId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.WithOwner("City")
                                .HasForeignKey("CityId");

                            b1.Navigation("Accommodation");

                            b1.Navigation("City");
                        });

                    b.Navigation("CityAccommodations");
                });

            modelBuilder.Entity("Domain.Entities.School", b =>
                {
                    b.HasOne("Domain.Entities.City", "City")
                        .WithMany("Schools")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Navigation("Schools");
                });
#pragma warning restore 612, 618
        }
    }
}
