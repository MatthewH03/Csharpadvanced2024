using Csharpadvanced2024.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpadvanced2024.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Location> Locations { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Landlord>().HasData
                (
                    new Landlord
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        Age = 55,
                    },

                    new Landlord
                    {
                        Id = 2,
                        FirstName = "Henk",
                        LastName = "Pieters",
                        Age = 40,
                    },

                    new Landlord
                    {
                        Id = 3,
                        FirstName = "Jan",
                        LastName = "Hollands",
                        Age = 36,
                    }
                );

            modelBuilder.Entity<Location>().HasData
                (
                    new Location
                    {
                        Id = 1,
                        Title = "Locatie nr. 1",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de eerste locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 2,
                        Title = "Locatie nr. 2",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de tweede locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 3,
                        Title = "De Boerenhoeve",
                        Subtitle = "Lekker veel ruimte",
                        Description = "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.",
                        Rooms = 5,
                        NumberOfGuests = 12,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location {
                        Id = 4,
                        Title = "Frankie's Penthouse",
                        Subtitle = "Te gek uitzicht",
                        Description = "Nee, dit puike penthouse dat al jaren te koop stond en nu is verkocht, is niet de duurste woning van ons land. Bij lange na niet. Wel is de meer dan €30.000 per vierkante meter woonruimte een record in ons land.",
                        Rooms = 2,
                        NumberOfGuests = 4,
                        PricePerDay = 400,
                        Type = (Location.LocationType)0,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 5,
                        Title = "Locatie nr. 5",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de vijfde locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 6,
                        Title = "Locatie nr. 6",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de zesde locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 7,
                        Title = "Locatie nr. 7",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de zevende locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 8,
                        Title = "Locatie nr. 8",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de achste locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 9,
                        Title = "Locatie nr. 9",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de negende locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 10,
                        Title = "Locatie nr. 10",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de tiende locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    }
                ) ; 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=AIRDB;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
