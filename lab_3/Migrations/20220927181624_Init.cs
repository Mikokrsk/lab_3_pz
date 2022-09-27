using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab_3.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Machine_componentsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sugar = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckPaper = table.Column<int>(type: "INTEGER", nullable: false),
                    Cups = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Machine_componentsId);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name_Drink = table.Column<string>(type: "TEXT", nullable: false),
                    Portion_Drink = table.Column<int>(type: "INTEGER", nullable: false),
                    Price_Drink = table.Column<int>(type: "INTEGER", nullable: false),
                    Machine_componentsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                    table.ForeignKey(
                        name: "FK_Drinks_Components_Machine_componentsId",
                        column: x => x.Machine_componentsId,
                        principalTable: "Components",
                        principalColumn: "Machine_componentsId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_Machine_componentsId",
                table: "Drinks",
                column: "Machine_componentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Components");
        }
    }
}
