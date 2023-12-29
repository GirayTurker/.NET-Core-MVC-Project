using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulk.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price2 = table.Column<double>(type: "float", nullable: false),
                    PriceMoreThan10 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandName", "Description", "Price", "Price2", "PriceMoreThan10", "SKU", "Title" },
                values: new object[,]
                {
                    { 1, "Brand Name-1", "Description-1", 50.0, 45.0, 40.0, "SKU-1", "Title-1" },
                    { 2, "Brand Name-2", "Description-2", 5.0, 4.5, 4.0, "SKU-2", "Title-2" },
                    { 3, "Brand Name-3", "Description-3", 25.0, 20.0, 15.0, "SKU-3", "Title-3" },
                    { 4, "Brand Name-4", "Description-4", 75.0, 70.0, 65.0, "SKU-4", "Title-4" },
                    { 5, "Brand Name-5", "Description-5", 15.0, 10.0, 7.5, "SKU-5", "Title-5" },
                    { 6, "Brand Name-6", "Description-6", 150.0, 120.0, 99.0, "SKU-6", "Title-6" },
                    { 7, "Brand Name-7", "Description-7", 255.0, 230.0, 210.0, "SKU-7", "Title-7" },
                    { 8, "Brand Name-8", "Description-8", 344.0, 320.0, 280.0, "SKU-8", "Title-8" },
                    { 9, "Brand Name-9", "Description-9", 9.0, 7.0, 4.0, "SKU-9", "Title-9" },
                    { 10, "Brand Name-10", "Description-10", 500.0, 450.0, 400.0, "SKU-10", "Title-10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
