#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace EVChargeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    BatteryCapacityKWh = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChargeStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    ChargeStationStatus = table.Column<int>(type: "int", nullable: false),
                    PricePerKWh = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false),
                    DataSource = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ExternalId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargeStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChargeStations_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Connectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectorType = table.Column<int>(type: "int", nullable: false),
                    PowerKw = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    ConnectorStatus = table.Column<int>(type: "int", nullable: false),
                    ChargeStationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Connectors_ChargeStations_ChargeStationId",
                        column: x => x.ChargeStationId,
                        principalTable: "ChargeStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChargingSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnergyKWh = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false),
                    AppliedPricePerKWh = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false),
                    ConnectorId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargingSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChargingSessions_Connectors_ConnectorId",
                        column: x => x.ConnectorId,
                        principalTable: "Connectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChargingSessions_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChargeStations_OperatorId",
                table: "ChargeStations",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChargingSessions_ConnectorId",
                table: "ChargingSessions",
                column: "ConnectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChargingSessions_VehicleId",
                table: "ChargingSessions",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Connectors_ChargeStationId",
                table: "Connectors",
                column: "ChargeStationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChargingSessions");

            migrationBuilder.DropTable(
                name: "Connectors");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "ChargeStations");

            migrationBuilder.DropTable(
                name: "Operators");
        }
    }
}
