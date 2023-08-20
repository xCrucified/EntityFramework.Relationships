using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Relationships.Migrations
{
    public partial class Fillingtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[,]
                {
                    { 1, "JebaQwerty123", "Qwerty1234" },
                    { 2, "ProMaster69", "Goldilocks" },
                    { 3, "Bob", "80932475fed" },
                    { 4, "BigFatCybersport", "ILikeFood123" },
                    { 5, "DatabaseHacker228", "ProGuildMen" },
                    { 6, "Bullet", "asdfqewrzcv14" },
                    { 7, "Michael", "12345678" },
                    { 8, "ChicagoSenior", "]qwer=-123.zcna[{JFeWRnp[1'341[" }
                });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "Id", "Capacity", "Country", "Kind", "Model" },
                values: new object[,]
                {
                    { 1, 40, "Toyota", "transportable", "Airbus A330" },
                    { 2, 25, "USA", "Sport", "Boeing 747" },
                    { 3, 77, "Ukraine", "Family", "Embraer E-Jet Family" },
                    { 4, 11, "Poland", "Broken", "Boeing 777" },
                    { 5, 37, "Spain", "ChillDrill", "Boeing 727" },
                    { 6, 76, "Japan", "transportable", "CRJ Series" },
                    { 7, 110, "Spain", "NotChill", "Airbus A320 Family" },
                    { 8, 97, "Egypt", "Private", "Boeing 737 Family" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AccountId", "Email", "Name", "Sex", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "asdf@gmail.com", "Bob", "Male", "AstralStep" },
                    { 2, 2, "IOP435@gmail.com", "Michael", "Famale", "Zangetsu" },
                    { 3, 3, "Tyvipt1324@gmail.com", "Oleg", "Male", "Retarded" },
                    { 4, 4, "Mmdkfk9@gmail.com", "Georgy", "Male", "Useless" },
                    { 5, 5, "Meg2@gmail.com", "Dasha", "Male", "ProMaster" },
                    { 6, 6, "Cook434@gmail.com", "Luda", "Falame", "Bobrovich" },
                    { 7, 7, "WhitchBane@gmail.com", "Stepan", "Male", "Idk" },
                    { 8, 8, "Steve@gmail.com", "Steve", "Steve", "Steve" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirplanesId", "ClientsId", "DateOfArrival", "DateOfDeparture", "Number", "PlaceArrivale", "PlaceDeparture" },
                values: new object[,]
                {
                    { 1, 1, 1, "1987-04-01", "1987-03-13", 43, "Airport 2", "Airport 1" },
                    { 2, 2, 2, "2001-04-01", "2001-03-12", 11, "Airport 3", "Airport 2" },
                    { 3, 3, 3, "2009-03-03", "2018-01-01", 2, "Airport 4", "Airport 3" },
                    { 4, 4, 4, "2021-01-01", "2020-12-29", 34, "Airport 5", "Airport 4" },
                    { 5, 5, 5, "943-12-12", "1002-01-32", 87, "Airport 6", "Airport 5" },
                    { 6, 6, 6, "1987-04-01", "1987-03-13", 673, "Airport 7", "Airport 6" },
                    { 7, 7, 7, "1987-04-01", "1987-03-13", 41, "Airport 8", "Airport 7" },
                    { 8, 8, 8, "1987-04-01", "1987-03-13", 1, "Airport 1", "Airport 8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
