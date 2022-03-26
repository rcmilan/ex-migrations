using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CitySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a6ad2fe-6318-454f-907e-a67b0893537a"), "Cidade N" },
                    { new Guid("0a6bd2fe-6318-454f-907e-b67b0893537a"), "Cidade S" },
                    { new Guid("0a6cd2fe-6318-454f-907e-c67b0893537a"), "Cidade L" },
                    { new Guid("0a6dd2fe-6318-454f-907e-d67b0893537a"), "Cidade O" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0a6ad2fe-6318-454f-907e-a67b0893537a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0a6bd2fe-6318-454f-907e-b67b0893537a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0a6cd2fe-6318-454f-907e-c67b0893537a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0a6dd2fe-6318-454f-907e-d67b0893537a"));
        }
    }
}
