using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_shopping.Migrations
{
    /// <inheritdoc />
    public partial class online_shopping_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category_id = table.Column<int>(type: "int", nullable: false),
                    Categoryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_category_Categoryid",
                        column: x => x.Categoryid,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Customerid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_orders_customers_Customerid",
                        column: x => x.Customerid,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payment_Information",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payment_Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_Information", x => x.id);
                    table.ForeignKey(
                        name: "FK_payment_Information_customers_Customer_id",
                        column: x => x.Customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shippingAddress",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postal_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Custome_id = table.Column<int>(type: "int", nullable: false),
                    Customerid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shippingAddress", x => x.id);
                    table.ForeignKey(
                        name: "FK_shippingAddress_customers_Customerid",
                        column: x => x.Customerid,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Customerid = table.Column<int>(type: "int", nullable: false),
                    Produc_id = table.Column<int>(type: "int", nullable: false),
                    productsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_reviews_customers_Customerid",
                        column: x => x.Customerid,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reviews_products_productsid",
                        column: x => x.productsid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    Order_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Productid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_orderItems_orders_Order_id",
                        column: x => x.Order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderItems_products_Productid",
                        column: x => x.Productid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_Order_id",
                table: "orderItems",
                column: "Order_id");

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_Productid",
                table: "orderItems",
                column: "Productid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Customerid",
                table: "orders",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_payment_Information_Customer_id",
                table: "payment_Information",
                column: "Customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_Categoryid",
                table: "products",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_Customerid",
                table: "reviews",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_productsid",
                table: "reviews",
                column: "productsid");

            migrationBuilder.CreateIndex(
                name: "IX_shippingAddress_Customerid",
                table: "shippingAddress",
                column: "Customerid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderItems");

            migrationBuilder.DropTable(
                name: "payment_Information");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "shippingAddress");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
