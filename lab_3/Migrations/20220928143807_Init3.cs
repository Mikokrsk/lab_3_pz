using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab_3.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_Machines_MachineId",
                table: "Components");

            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Machines_MachineId",
                table: "Drinks");

            migrationBuilder.DropIndex(
                name: "IX_Drinks_MachineId",
                table: "Drinks");

            migrationBuilder.DropIndex(
                name: "IX_Components_MachineId",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Components");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Drinks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Components",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_MachineId",
                table: "Drinks",
                column: "MachineId");

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
    }
}
