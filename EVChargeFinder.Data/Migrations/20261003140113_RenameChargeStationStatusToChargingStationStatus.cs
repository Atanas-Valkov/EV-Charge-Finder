using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVChargeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameChargeStationStatusToChargingStationStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.RenameColumn(
                name: "ChargeStationStatus",
                table: "ChargingStations",
                newName: "ChargingStationStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChargingStationStatus",
                table: "ChargingStations",
                newName: "ChargeStationStatus");

        }
    }
}
