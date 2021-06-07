using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class MakeEngineerNameUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EngineerName",
                table: "Engineers",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_EngineerName",
                table: "Engineers",
                column: "EngineerName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Engineers_EngineerName",
                table: "Engineers");

            migrationBuilder.AlterColumn<string>(
                name: "EngineerName",
                table: "Engineers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);
        }
    }
}
