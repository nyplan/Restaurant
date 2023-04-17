using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAPI.Migrations
{
    /// <inheritdoc />
    public partial class addByCall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ByCalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    ReserverInfoId = table.Column<int>(type: "int", nullable: false),
                    CallTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ByCalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ByCalls_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ByCalls_ReserverInfos_ReserverInfoId",
                        column: x => x.ReserverInfoId,
                        principalTable: "ReserverInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ByCalls_ReservationId",
                table: "ByCalls",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ByCalls_ReserverInfoId",
                table: "ByCalls",
                column: "ReserverInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ByCalls");
        }
    }
}
