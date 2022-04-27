using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 3, "Male", "Nyangs", "Cat" },
                    { 2, 4, "Male", "Popeyes", "Cat" },
                    { 3, 1, "Female", "Dunkin", "Cat" },
                    { 4, 2, "Female", "Sadcat", "Cat" },
                    { 5, 3, "Female", "Inu", "Dog" },
                    { 6, 6, "Male", "Maru", "Dog" },
                    { 7, 5, "Male", "Kissy", "Dog" },
                    { 8, 10, "Male", "Mlem", "Cat" },
                    { 9, 100, "Male", "Applebees", "Cat" },
                    { 10, 5, "Male", "Greg", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}