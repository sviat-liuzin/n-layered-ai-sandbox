using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedPanda.NLayered.Data.Sql.Migrations
{
    /// <inheritdoc />
    public partial class Modify_MyMaps_AddTemperature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyMaps",
                table: "MyMaps");

            migrationBuilder.RenameColumn(
                name: "CurrentForecast",
                table: "MyMaps",
                newName: "MapData");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "MyMaps",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<double>(
                name: "LastReportedTemperatureC",
                table: "MyMaps",
                type: "float",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyMaps",
                table: "MyMaps",
                columns: new[] { "Id", "Date" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyMaps",
                table: "MyMaps");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "MyMaps");

            migrationBuilder.DropColumn(
                name: "LastReportedTemperatureC",
                table: "MyMaps");

            migrationBuilder.RenameColumn(
                name: "MapData",
                table: "MyMaps",
                newName: "CurrentForecast");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyMaps",
                table: "MyMaps",
                column: "Id");
        }
    }
}
