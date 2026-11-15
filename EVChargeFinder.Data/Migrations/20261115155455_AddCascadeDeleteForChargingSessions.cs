using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVChargeFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCascadeDeleteForChargingSessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChargingSessions_AspNetUsers_UserId",
                table: "ChargingSessions");

            migrationBuilder.AddForeignKey(
                name: "FK_ChargingSessions_AspNetUsers_UserId",
                table: "ChargingSessions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChargingSessions_AspNetUsers_UserId",
                table: "ChargingSessions");

            migrationBuilder.AddForeignKey(
                name: "FK_ChargingSessions_AspNetUsers_UserId",
                table: "ChargingSessions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
