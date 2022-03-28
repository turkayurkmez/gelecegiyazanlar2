using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bootShop.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Descriptipn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Telefon" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Laptop" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Tablet" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Descriptipn", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, null, 0.14999999999999999, "https://productimages.hepsiburada.net/s/65/200-200/110000007077895.jpg", null, "IPhone", 1500.0 },
                    { 2, 1, null, null, 0.14999999999999999, "https://productimages.hepsiburada.net/s/65/200-200/110000007077895.jpg", null, "Oppo", 1500.0 },
                    { 3, 1, null, null, 0.14999999999999999, "https://productimages.hepsiburada.net/s/65/200-200/110000007077895.jpg", null, "Xiaomi", 1500.0 },
                    { 4, 2, null, null, 0.14999999999999999, "https://productimages.hepsiburada.net/s/195/200-200/110000163717661.jpg", null, "Macbook pro", 1500.0 },
                    { 5, 2, null, null, 0.14999999999999999, "https://productimages.hepsiburada.net/s/195/200-200/110000163717661.jpg", null, "Dell XPS 13", 1500.0 },
                    { 6, 2, null, null, 0.14999999999999999, "https://productimages.hepsiburada.net/s/195/200-200/110000163717661.jpg", null, "Huawei", 1500.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
