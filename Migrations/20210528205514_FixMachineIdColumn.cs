using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class FixMachineIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineEngineer_Machines_MachineId",
                table: "MachineEngineer");

            migrationBuilder.DropColumn(
                name: "MachinedId",
                table: "MachineEngineer");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "MachineEngineer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineEngineer_Machines_MachineId",
                table: "MachineEngineer",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineEngineer_Machines_MachineId",
                table: "MachineEngineer");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "MachineEngineer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MachinedId",
                table: "MachineEngineer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineEngineer_Machines_MachineId",
                table: "MachineEngineer",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
