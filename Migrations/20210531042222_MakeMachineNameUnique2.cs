using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class MakeMachineNameUnique2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MachineName",
                table: "Machines",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Machines_MachineName",
                table: "Machines",
                column: "MachineName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Machines_MachineName",
                table: "Machines");

            migrationBuilder.AlterColumn<string>(
                name: "MachineName",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);
        }
    }
}
