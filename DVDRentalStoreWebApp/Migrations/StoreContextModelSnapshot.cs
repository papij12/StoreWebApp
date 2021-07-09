﻿// <auto-generated />
using System;
using DVDRentalStoreWebApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DVDRentalStoreWebApp.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Copy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Copies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Available = true,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            Available = true,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 3,
                            Available = false,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 4,
                            Available = true,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 5,
                            Available = true,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 6,
                            Available = true,
                            MovieId = 5
                        });
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 12.0,
                            Title = "Anchorman",
                            Year = 2000
                        },
                        new
                        {
                            Id = 2,
                            Price = 7.0,
                            Title = "Anchorman 2",
                            Year = 2001
                        },
                        new
                        {
                            Id = 3,
                            Price = 22.0,
                            Title = "Terminator",
                            Year = 1993
                        },
                        new
                        {
                            Id = 4,
                            Price = 29.0,
                            Title = "Jurassic Park",
                            Year = 1999
                        },
                        new
                        {
                            Id = 5,
                            Price = 11.0,
                            Title = "The Lord of the Rings",
                            Year = 1997
                        });
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Client", b =>
                {
                    b.HasBaseType("DVDRentalStoreWebApp.Models.Person");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            FirstName = "Bob",
                            LastName = "Belcher",
                            Birthday = new DateTime(1977, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Hank",
                            LastName = "Hill",
                            Birthday = new DateTime(1954, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Employee", b =>
                {
                    b.HasBaseType("DVDRentalStoreWebApp.Models.Person");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Jace",
                            LastName = "Beleren",
                            HireDate = new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Poznan"
                        });
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Copy", b =>
                {
                    b.HasOne("DVDRentalStoreWebApp.Models.Movie", "Movie")
                        .WithMany("Copies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Client", b =>
                {
                    b.HasOne("DVDRentalStoreWebApp.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DVDRentalStoreWebApp.Models.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Employee", b =>
                {
                    b.HasOne("DVDRentalStoreWebApp.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DVDRentalStoreWebApp.Models.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DVDRentalStoreWebApp.Models.Movie", b =>
                {
                    b.Navigation("Copies");
                });
#pragma warning restore 612, 618
        }
    }
}
