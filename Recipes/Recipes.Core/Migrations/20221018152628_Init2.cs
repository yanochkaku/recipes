using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.Core.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoDishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorDish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CookingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preparation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoDishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoDishes_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfoDishes_RecipesId",
                table: "InfoDishes",
                column: "RecipesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoDishes");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
