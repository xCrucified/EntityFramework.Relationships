using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Relationships.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountsClients",
                columns: table => new
                {
                    AccountsId = table.Column<int>(type: "int", nullable: false),
                    ClientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsClients", x => new { x.AccountsId, x.ClientsId });
                    table.ForeignKey(
                        name: "FK_AccountsClients_Accounts_AccountsId",
                        column: x => x.AccountsId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsClients_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    AirplanesId = table.Column<int>(type: "int", nullable: false),
                    ClientsId = table.Column<int>(type: "int", nullable: false),
                    DateOfDeparture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfArrival = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceDeparture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceArrivale = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Airplanes_AirplanesId",
                        column: x => x.AirplanesId,
                        principalTable: "Airplanes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flights_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Id", "AccountId", "Email", "IsMale", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "asdf@gmail.com", true, "Bob", "AstralStep" },
                    { 2, 2, "IOP435@gmail.com", false, "Michael", "Zangetsu" },
                    { 3, 3, "Tyvipt1324@gmail.com", true, "Oleg", "Retarded" },
                    { 4, 4, "Mmdkfk9@gmail.com", true, "Georgy", "Useless" },
                    { 5, 5, "Meg2@gmail.com", false, "Dasha", "ProMaster" },
                    { 6, 6, "Cook434@gmail.com", true, "Luda", "Bobrovich" },
                    { 7, 7, "WhitchBane@gmail.com", true, "Stepan", "Idk" },
                    { 8, 8, "Steve@gmail.com", true, "Steve", "Steve" }
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

            migrationBuilder.CreateIndex(
                name: "IX_AccountsClients_ClientsId",
                table: "AccountsClients",
                column: "ClientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirplanesId",
                table: "Flights",
                column: "AirplanesId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ClientsId",
                table: "Flights",
                column: "ClientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsClients");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
