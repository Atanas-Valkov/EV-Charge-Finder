
namespace EVChargeFinder.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;
    public partial class RenameChargeStationToChargingStation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ChargeStations",
                newName: "ChargingStations");

            migrationBuilder.RenameColumn(
                name: "ChargeStationStatus",
                table: "ChargingStations",
                newName: "ChargingStationStatus");

            migrationBuilder.RenameColumn(
                name: "ChargeStationId",
                table: "Connectors",
                newName: "ChargingStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Connectors_ChargeStationId_ConnectorNumber",
                table: "Connectors",
                newName: "IX_Connectors_ChargingStationId_ConnectorNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_Connectors_ChargingStationId_ConnectorNumber",
                table: "Connectors",
                newName: "IX_Connectors_ChargeStationId_ConnectorNumber");

            migrationBuilder.RenameColumn(
                name: "ChargingStationStatus",
                table: "ChargingStations",
                newName: "ChargeStationStatus");

            migrationBuilder.RenameColumn(
                name: "ChargingStationId",
                table: "Connectors",
                newName: "ChargeStationId");

            migrationBuilder.RenameTable(
                name: "ChargingStations",
                newName: "ChargeStations");
        }
    }
}