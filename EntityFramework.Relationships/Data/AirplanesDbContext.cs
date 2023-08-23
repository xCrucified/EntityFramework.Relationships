using EntityFramework.Relationships.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Relationships.Data
{
    public class AirplanesDbContext : DbContext
    {
        public AirplanesDbContext() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AirplanesDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Accounts>().HasData(new[]
            {
                 new Accounts() {Id = 1, Login = "JebaQwerty123", Password = "Qwerty1234"},
                 new Accounts() {Id = 2, Login = "ProMaster69", Password = "Goldilocks"},
                 new Accounts() {Id = 3, Login = "Bob", Password = "80932475fed"},
                 new Accounts() {Id = 4, Login = "BigFatCybersport", Password = "ILikeFood123"},
                 new Accounts() {Id = 5, Login = "DatabaseHacker228", Password = "ProGuildMen"},
                 new Accounts() {Id = 6, Login = "Bullet", Password = "asdfqewrzcv14"},
                 new Accounts() {Id = 8, Login = "ChicagoSenior", Password = "]qwer=-123.zcna[{JFeWRnp[1'341["},
                 new Accounts() {Id = 7, Login = "Michael", Password = "12345678"},
            });
            modelBuilder.Entity<Airplanes>().HasData(new[]
            {
                new Airplanes() {Id = 1, Model = "Airbus A330", Capacity = 40, Country = "Toyota", Kind = "transportable"},
                new Airplanes() {Id = 2, Model = "Boeing 747", Capacity = 25, Country = "USA", Kind = "Sport"},
                new Airplanes() {Id = 3, Model = "Embraer E-Jet Family", Capacity = 77, Country = "Ukraine", Kind = "Family"},
                new Airplanes() {Id = 4, Model = "Boeing 777", Capacity = 11, Country = "Poland", Kind = "Broken"},
                new Airplanes() {Id = 5, Model = "Boeing 727", Capacity = 37, Country = "Spain", Kind = "ChillDrill"},
                new Airplanes() {Id = 6, Model = "CRJ Series", Capacity = 76, Country = "Japan", Kind = "transportable"},
                new Airplanes() {Id = 7, Model = "Airbus A320 Family", Capacity = 110, Country = "Spain", Kind = "NotChill"},
                new Airplanes() {Id = 8, Model = "Boeing 737 Family", Capacity = 97, Country = "Egypt", Kind = "Private"},
            });
            modelBuilder.Entity<Clients>().HasData(new[]
            {
                new Clients() {Id = 1, AccountId = 1, Email = "asdf@gmail.com", Name = "Bob", Sex = "Male", Surname = "AstralStep"},
                new Clients() {Id = 2, AccountId = 2, Email = "IOP435@gmail.com", Name = "Michael", Sex = "Famale", Surname = "Zangetsu"},
                new Clients() {Id = 3, AccountId = 3, Email = "Tyvipt1324@gmail.com", Name = "Oleg", Sex = "Male", Surname = "Retarded"},
                new Clients() {Id = 4, AccountId = 4, Email = "Mmdkfk9@gmail.com", Name = "Georgy", Sex = "Male", Surname = "Useless"},
                new Clients() {Id = 5, AccountId = 5, Email = "Meg2@gmail.com", Name = "Dasha", Sex = "Male", Surname = "ProMaster"},
                new Clients() {Id = 6, AccountId = 6, Email = "Cook434@gmail.com", Name = "Luda", Sex = "Falame", Surname = "Bobrovich"},
                new Clients() {Id = 7, AccountId = 7, Email = "WhitchBane@gmail.com", Name = "Stepan", Sex = "Male", Surname = "Idk"},
                new Clients() {Id = 8, AccountId = 8, Email = "Steve@gmail.com", Name = "Steve", Sex = "Steve", Surname = "Steve"},
            });
            modelBuilder.Entity<Flights>().HasData(new[]
            {
                new Flights() {Id = 1, Number = 43, AirplanesId = 1, ClientsId = 1, DateOfDeparture = "1987-03-13", DateOfArrival = "1987-04-01", PlaceDeparture = "Airport 1", PlaceArrivale = "Airport 2"},
                new Flights() {Id = 2, Number = 11, AirplanesId = 2, ClientsId = 2, DateOfDeparture = "2001-03-12", DateOfArrival = "2001-04-01", PlaceDeparture = "Airport 2", PlaceArrivale = "Airport 3"},
                new Flights() {Id = 3, Number = 2, AirplanesId = 3, ClientsId = 3, DateOfDeparture = "2018-01-01", DateOfArrival = "2009-03-03", PlaceDeparture = "Airport 3", PlaceArrivale = "Airport 4"},
                new Flights() {Id = 4, Number = 34, AirplanesId = 4, ClientsId = 4, DateOfDeparture = "2020-12-29", DateOfArrival = "2021-01-01", PlaceDeparture = "Airport 4", PlaceArrivale = "Airport 5"},
                new Flights() {Id = 5, Number = 87, AirplanesId = 5, ClientsId = 5, DateOfDeparture = "1002-01-32", DateOfArrival = "943-12-12", PlaceDeparture = "Airport 5", PlaceArrivale = "Airport 6"},
                new Flights() {Id = 6, Number = 673, AirplanesId = 6, ClientsId = 6, DateOfDeparture = "1987-03-13", DateOfArrival = "1987-04-01", PlaceDeparture = "Airport 6", PlaceArrivale = "Airport 7"},
                new Flights() {Id = 7, Number = 41, AirplanesId = 7, ClientsId = 7, DateOfDeparture = "1987-03-13", DateOfArrival = "1987-04-01", PlaceDeparture = "Airport 7", PlaceArrivale = "Airport 8"},
                new Flights() {Id = 8, Number = 1, AirplanesId = 8, ClientsId = 8, DateOfDeparture = "1987-03-13", DateOfArrival = "1987-04-01", PlaceDeparture = "Airport 8", PlaceArrivale = "Airport 1"},
            });
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Airplanes> Airplanes { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Flights> Flights { get; set; }
    }
}
