using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InsertSeedDataToProductsTableInDB : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price20 = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fantasy");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Adventure");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "Price", "Price20", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Stieg Larsson", 1, "The two primary characters in the saga are Lisbeth Salander, an asocial computer hacker with a photographic memory, and Mikael Blomkvist, an investigative journalist.", "SW9780307949486", 40.0, 25.0, 20.0, "The Girl with the Dragon Tattoo" },
                    { 2, "J.R.R. Tolkien", 3, "Follow hobbit icon Frodo and his friends on his perilous, unforgettable journey to destroy the One Ring, once and for all.", "CA9780544003415", 50.0, 40.0, 30.0, "The Lord of the Rings" },
                    { 3, "Suzanne Collins", 2, "The Hunger Games follows 16-year-old Katniss Everdeen, a girl from District 12 who volunteers for the 74th Hunger Games in place of her younger sister Primrose Everdeen.", "RI9781627656368", 50.0, 40.0, 35.0, "The Hunger Games" },
                    { 4, "J.K. Rowling", 2, "Harry Potter is about to start his fifth year at Hogwarts School of Witchcraft and Wizardry.Harry never enjoys his summer holidays, but this summer is even worse than usual. ", "WS9780747532743", 65.0, 60.0, 55.0, "Harry Potter" },
                    { 5, "Yann Martel", 3, "The protagonist, Piscine Molitor 'Pi' Patel, a Tamil boy from Pondicherry, explores issues of spirituality and practicality from an early age. ", "ST0156030209", 20.0, 15.0, 10.0, "Life of Pi" },
                    { 6, "Jon Krakauer", 3, "A young man from a well-to-do family hitchhiked to Alaska and walked alone into the wilderness north of Mt. McKinley.", "FO9780307387172", 25.0, 20.0, 15.0, "Into the Wild" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "History");
        }
    }
}
