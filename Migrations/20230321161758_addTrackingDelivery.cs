using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAPI.Migrations
{
    /// <inheritdoc />
    public partial class addTrackingDelivery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrackingDeliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    CourierId = table.Column<int>(type: "int", nullable: false),
                    TrackingStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackingDeliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackingDeliveries_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackingDeliveries_Couriers_CourierId",
                        column: x => x.CourierId,
                        principalTable: "Couriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackingDeliveries_TrackingStatuses_TrackingStatusId",
                        column: x => x.TrackingStatusId,
                        principalTable: "TrackingStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackingDeliveries_BasketId",
                table: "TrackingDeliveries",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackingDeliveries_CourierId",
                table: "TrackingDeliveries",
                column: "CourierId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackingDeliveries_TrackingStatusId",
                table: "TrackingDeliveries",
                column: "TrackingStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackingDeliveries");
        }
    }
}
