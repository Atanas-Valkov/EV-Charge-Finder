using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVChargeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndexesBeforeInitialSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ChargeStations_OperatorId",
                table: "ChargeStations");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_Name",
                table: "Operators",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChargeStations_OperatorId_Name_Latitude_Longitude",
                table: "ChargeStations",
                columns: new[] { "OperatorId", "Name", "Latitude", "Longitude" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Operators_Name",
                table: "Operators");

            migrationBuilder.DropIndex(
                name: "IX_ChargeStations_OperatorId_Name_Latitude_Longitude",
                table: "ChargeStations");

            migrationBuilder.CreateIndex(
                name: "IX_ChargeStations_OperatorId",
                table: "ChargeStations",
                column: "OperatorId");
        }
    }
}
