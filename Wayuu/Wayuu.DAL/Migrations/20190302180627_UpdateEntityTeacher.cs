using Microsoft.EntityFrameworkCore.Migrations;

namespace Wayuu.DAL.Migrations
{
    public partial class UpdateEntityTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Teachers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
