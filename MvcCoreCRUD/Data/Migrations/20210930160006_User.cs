using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Course_tb_Student_nameId",
                table: "tb_Course");

            migrationBuilder.AlterColumn<int>(
                name: "nameId",
                table: "tb_Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Course_tb_Student_nameId",
                table: "tb_Course",
                column: "nameId",
                principalTable: "tb_Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Course_tb_Student_nameId",
                table: "tb_Course");

            migrationBuilder.AlterColumn<int>(
                name: "nameId",
                table: "tb_Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Course_tb_Student_nameId",
                table: "tb_Course",
                column: "nameId",
                principalTable: "tb_Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
