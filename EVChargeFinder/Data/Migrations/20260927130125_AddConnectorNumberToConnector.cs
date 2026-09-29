using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVChargeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddConnectorNumberToConnector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Connectors_ChargeStationId",
                table: "Connectors");

            migrationBuilder.AddColumn<int>(
                name: "ConnectorNumber",
                table: "Connectors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Connectors_ChargeStationId_ConnectorNumber",
                table: "Connectors",
                columns: new[] { "ChargeStationId", "ConnectorNumber" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Connectors_ChargeStationId_ConnectorNumber",
                table: "Connectors");

            migrationBuilder.DropColumn(
                name: "ConnectorNumber",
                table: "Connectors");

            migrationBuilder.CreateIndex(
                name: "IX_Connectors_ChargeStationId",
                table: "Connectors",
                column: "ChargeStationId");
        }
    }
}
