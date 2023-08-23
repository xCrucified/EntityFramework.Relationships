﻿// <auto-generated />
using EntityFramework.Relationships.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramework.Relationships.Migrations
{
    [DbContext(typeof(AirplanesDbContext))]
    partial class AirplanesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AccountsClients", b =>
                {
                    b.Property<int>("AccountsId")
                        .HasColumnType("int");

                    b.Property<int>("ClientsId")
                        .HasColumnType("int");

                    b.HasKey("AccountsId", "ClientsId");

                    b.HasIndex("ClientsId");

                    b.ToTable("AccountsClients");
                });

            modelBuilder.Entity("EntityFramework.Relationships.Entities.Accounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "JebaQwerty123",
                            Password = "Qwerty1234"
                        },
                        new
                        {
                            Id = 2,
                            Login = "ProMaster69",
                            Password = "Goldilocks"
                        },
                        new
                        {
                            Id = 3,
                            Login = "Bob",
                            Password = "80932475fed"
                        },
                        new
                        {
                            Id = 4,
                            Login = "BigFatCybersport",
                            Password = "ILikeFood123"
                        },
                        new
                        {
                            Id = 5,
                            Login = "DatabaseHacker228",
                            Password = "ProGuildMen"
                        },
                        new
                        {
                            Id = 6,
                            Login = "Bullet",
                            Password = "asdfqewrzcv14"
                        },
                        new
                        {
                            Id = 8,
                            Login = "ChicagoSenior",
                            Password = "]qwer=-123.zcna[{JFeWRnp[1'341["
                        },
                        new
                        {
                            Id = 7,
                            Login = "Michael",
                            Password = "12345678"
                        });
                });

            modelBuilder.Entity("EntityFramework.Relationships.Entities.Airplanes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kind")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airplanes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 40,
                            Country = "Toyota",
                            Kind = "transportable",
                            Model = "Airbus A330"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 25,
                            Country = "USA",
                            Kind = "Sport",
                            Model = "Boeing 747"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 77,
                            Country = "Ukraine",
                            Kind = "Family",
                            Model = "Embraer E-Jet Family"
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 11,
                            Country = "Poland",
                            Kind = "Broken",
                            Model = "Boeing 777"
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 37,
                            Country = "Spain",
                            Kind = "ChillDrill",
                            Model = "Boeing 727"
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 76,
                            Country = "Japan",
                            Kind = "transportable",
                            Model = "CRJ Series"
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 110,
                            Country = "Spain",
                            Kind = "NotChill",
                            Model = "Airbus A320 Family"
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 97,
                            Country = "Egypt",
                            Kind = "Private",
                            Model = "Boeing 737 Family"
                        });
                });

            modelBuilder.Entity("EntityFramework.Relationships.Entities.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            Email = "asdf@gmail.com",
                            IsMale = true,
                            Name = "Bob",
                            Surname = "AstralStep"
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            Email = "IOP435@gmail.com",
                            IsMale = false,
                            Name = "Michael",
                            Surname = "Zangetsu"
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 3,
                            Email = "Tyvipt1324@gmail.com",
                            IsMale = true,
                            Name = "Oleg",
                            Surname = "Retarded"
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 4,
                            Email = "Mmdkfk9@gmail.com",
                            IsMale = true,
                            Name = "Georgy",
                            Surname = "Useless"
                        },
                        new
                        {
                            Id = 5,
                            AccountId = 5,
                            Email = "Meg2@gmail.com",
                            IsMale = false,
                            Name = "Dasha",
                            Surname = "ProMaster"
                        },
                        new
                        {
                            Id = 6,
                            AccountId = 6,
                            Email = "Cook434@gmail.com",
                            IsMale = true,
                            Name = "Luda",
                            Surname = "Bobrovich"
                        },
                        new
                        {
                            Id = 7,
                            AccountId = 7,
                            Email = "WhitchBane@gmail.com",
                            IsMale = true,
                            Name = "Stepan",
                            Surname = "Idk"
                        },
                        new
                        {
                            Id = 8,
                            AccountId = 8,
                            Email = "Steve@gmail.com",
                            IsMale = true,
                            Name = "Steve",
                            Surname = "Steve"
                        });
                });

            modelBuilder.Entity("EntityFramework.Relationships.Entities.Flights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AirplanesId")
                        .HasColumnType("int");

                    b.Property<int>("ClientsId")
                        .HasColumnType("int");

                    b.Property<string>("DateOfArrival")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfDeparture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("PlaceArrivale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceDeparture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirplanesId");

                    b.HasIndex("ClientsId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AirplanesId = 1,
                            ClientsId = 1,
                            DateOfArrival = "1987-04-01",
                            DateOfDeparture = "1987-03-13",
                            Number = 43,
                            PlaceArrivale = "Airport 2",
                            PlaceDeparture = "Airport 1"
                        },
                        new
                        {
                            Id = 2,
                            AirplanesId = 2,
                            ClientsId = 2,
                            DateOfArrival = "2001-04-01",
                            DateOfDeparture = "2001-03-12",
                            Number = 11,
                            PlaceArrivale = "Airport 3",
                            PlaceDeparture = "Airport 2"
                        },
                        new
                        {
                            Id = 3,
                            AirplanesId = 3,
                            ClientsId = 3,
                            DateOfArrival = "2009-03-03",
                            DateOfDeparture = "2018-01-01",
                            Number = 2,
                            PlaceArrivale = "Airport 4",
                            PlaceDeparture = "Airport 3"
                        },
                        new
                        {
                            Id = 4,
                            AirplanesId = 4,
                            ClientsId = 4,
                            DateOfArrival = "2021-01-01",
                            DateOfDeparture = "2020-12-29",
                            Number = 34,
                            PlaceArrivale = "Airport 5",
                            PlaceDeparture = "Airport 4"
                        },
                        new
                        {
                            Id = 5,
                            AirplanesId = 5,
                            ClientsId = 5,
                            DateOfArrival = "943-12-12",
                            DateOfDeparture = "1002-01-32",
                            Number = 87,
                            PlaceArrivale = "Airport 6",
                            PlaceDeparture = "Airport 5"
                        },
                        new
                        {
                            Id = 6,
                            AirplanesId = 6,
                            ClientsId = 6,
                            DateOfArrival = "1987-04-01",
                            DateOfDeparture = "1987-03-13",
                            Number = 673,
                            PlaceArrivale = "Airport 7",
                            PlaceDeparture = "Airport 6"
                        },
                        new
                        {
                            Id = 7,
                            AirplanesId = 7,
                            ClientsId = 7,
                            DateOfArrival = "1987-04-01",
                            DateOfDeparture = "1987-03-13",
                            Number = 41,
                            PlaceArrivale = "Airport 8",
                            PlaceDeparture = "Airport 7"
                        },
                        new
                        {
                            Id = 8,
                            AirplanesId = 8,
                            ClientsId = 8,
                            DateOfArrival = "1987-04-01",
                            DateOfDeparture = "1987-03-13",
                            Number = 1,
                            PlaceArrivale = "Airport 1",
                            PlaceDeparture = "Airport 8"
                        });
                });

            modelBuilder.Entity("AccountsClients", b =>
                {
                    b.HasOne("EntityFramework.Relationships.Entities.Accounts", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework.Relationships.Entities.Clients", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFramework.Relationships.Entities.Flights", b =>
                {
                    b.HasOne("EntityFramework.Relationships.Entities.Airplanes", "Airplanes")
                        .WithMany("Flights")
                        .HasForeignKey("AirplanesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework.Relationships.Entities.Clients", "Clients")
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplanes");

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("EntityFramework.Relationships.Entities.Airplanes", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}