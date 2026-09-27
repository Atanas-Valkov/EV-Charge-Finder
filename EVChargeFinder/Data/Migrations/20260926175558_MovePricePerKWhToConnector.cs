#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace EVChargeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class MovePricePerKWhToConnector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerKWh",
                table: "ChargeStations");

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerKWh",
                table: "Connectors",
                type: "decimal(8,4)",
                precision: 8,
                scale: 4,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerKWh",
                table: "Connectors");

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerKWh",
                table: "ChargeStations",
                type: "decimal(8,4)",
                precision: 8,
                scale: 4,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
