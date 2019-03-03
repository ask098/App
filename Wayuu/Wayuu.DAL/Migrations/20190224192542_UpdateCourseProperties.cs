using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wayuu.DAL.Migrations
{
    public partial class UpdateCourseProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Courses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Enroll",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishDate",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MaxCapacity",
                table: "Courses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Enroll",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "FinishDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "MaxCapacity",
                table: "Courses");
        }
    }
}
