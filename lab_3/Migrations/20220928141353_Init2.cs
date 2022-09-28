using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab_3.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Components_Machine_componentsId",
                table: "Drinks");

            migrationBuilder.RenameColumn(
                name: "Machine_componentsId",
                table: "Drinks",
                newName: "MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_Drinks_Machine_componentsId",
                table: "Drinks",
                newName: "IX_Drinks_MachineId");

            migrationBuilder.RenameColumn(
                name: "Machine_componentsId",
                table: "Components",
                newName: "Machine_componentId");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Components",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    MachineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Machine_components = table.Column<int>(type: "INTEGER", nullable: false),
                    Drink_1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Drink_2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Drink_3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Drink_4 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.MachineId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_MachineId",
                table: "Components",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_Machines_MachineId",
                table: "Components",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Machines_MachineId",
                table: "Drinks",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_Machines_MachineId",
                table: "Components");

            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Machines_MachineId",
                table: "Drinks");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Components_MachineId",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Components");

            migrationBuilder.RenameColumn(
                name: "MachineId",
                table: "Drinks",
                newName: "Machine_componentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Drinks_MachineId",
                table: "Drinks",
                newName: "IX_Drinks_Machine_componentsId");

            migrationBuilder.RenameColumn(
                name: "Machine_componentId",
                table: "Components",
                newName: "Machine_componentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Components_Machine_componentsId",
                table: "Drinks",
                column: "Machine_componentsId",
                principalTable: "Components",
                principalColumn: "Machine_componentsId");
        }
    }
}
