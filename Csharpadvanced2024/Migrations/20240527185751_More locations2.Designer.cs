﻿// <auto-generated />
using System;
using Csharpadvanced2024.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240527185751_More locations2")]
    partial class Morelocations2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Csharpadvanced2024.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Landlords");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Dit is de eerste locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 1",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dit is de tweede locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 2",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.",
                            Features = 0,
                            NumberOfGuests = 12,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Lekker veel ruimte",
                            Title = "De Boerenhoeve",
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Nee, dit puike penthouse dat al jaren te koop stond en nu is verkocht, is niet de duurste woning van ons land. Bij lange na niet. Wel is de meer dan €30.000 per vierkante meter woonruimte een record in ons land.",
                            Features = 0,
                            NumberOfGuests = 4,
                            PricePerDay = 400f,
                            Rooms = 2,
                            Subtitle = "Te gek uitzicht",
                            Title = "Frankie's Penthouse",
                            Type = 0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Dit is de vijfde locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 5",
                            Type = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Dit is de zesde locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 6",
                            Type = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "Dit is de zevende locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 7",
                            Type = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Dit is de achste locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 8",
                            Type = 1
                        },
                        new
                        {
                            Id = 9,
                            Description = "Dit is de negende locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 9",
                            Type = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "Dit is de tiende locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 10",
                            Type = 1
                        });
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("LandlordLocation", b =>
                {
                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("LocationsId")
                        .HasColumnType("int");

                    b.HasKey("LandlordId", "LocationsId");

                    b.HasIndex("LocationsId");

                    b.ToTable("LandlordLocation");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Image", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Location", null)
                        .WithMany("Images")
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Landlord", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Reservation", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Csharpadvanced2024.Models.Location", null)
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("LandlordLocation", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Landlord", null)
                        .WithMany()
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Csharpadvanced2024.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}