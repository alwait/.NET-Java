using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PogodaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZapisyPogody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    miasto = table.Column<string>(type: "TEXT", nullable: false),
                    temperatura = table.Column<double>(type: "REAL", nullable: false),
                    wilgotnosc = table.Column<double>(type: "REAL", nullable: false),
                    wiatr = table.Column<double>(type: "REAL", nullable: false),
                    data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZapisyPogody", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ZapisyPogody",
                columns: new[] { "Id", "data", "miasto", "temperatura", "wiatr", "wilgotnosc" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warszawa", 21.370000000000001, 1.1000000000000001, 40.0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kraków", 15.119999999999999, 0.40000000000000002, 61.0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Łódź", 10.5, 1.7, 52.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZapisyPogody");
        }
    }
}
