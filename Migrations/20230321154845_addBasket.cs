using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantAPI.Migrations
{
    /// <inheritdoc />
    public partial class addBasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    CreditCartId = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_CreditCarts_CreditCartId",
                        column: x => x.CreditCartId,
                        principalTable: "CreditCarts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Baskets_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Baskets_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CreditCartId",
                table: "Baskets",
                column: "CreditCartId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CustomersId",
                table: "Baskets",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_DiscountId",
                table: "Baskets",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_PaymentTypeId",
                table: "Baskets",
                column: "PaymentTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");
        }
    }
}
