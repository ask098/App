using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wayuu.DAL.Migrations
{
    public partial class SchoolComplete2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation_date",
                table: "Schools",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Creation_date",
                table: "Schools",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "now()");
        }
    }
}
