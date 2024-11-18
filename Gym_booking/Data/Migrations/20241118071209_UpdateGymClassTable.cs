using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_booking.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGymClassTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GymClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "GymClass",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GymClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "GymClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "GymClass");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "GymClass");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GymClass");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "GymClass");
        }
    }
}
