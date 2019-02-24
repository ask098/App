using Microsoft.EntityFrameworkCore.Migrations;

namespace Wayuu.DAL.Migrations
{
    public partial class ModifyStudenStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Birthdate",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Cid",
                table: "Students",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Municipality",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipeCid",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Cid",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Municipality",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TipeCid",
                table: "Students");
        }
    }
}
