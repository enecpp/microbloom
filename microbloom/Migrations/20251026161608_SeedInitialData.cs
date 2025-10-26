using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace microbloom.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 10, 26, 16, 16, 8, 308, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 10, 26, 16, 16, 8, 308, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 10, 26, 16, 16, 8, 308, DateTimeKind.Utc).AddTicks(891));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 10, 26, 16, 15, 38, 838, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 10, 26, 16, 15, 38, 838, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 10, 26, 16, 15, 38, 838, DateTimeKind.Utc).AddTicks(5070));
        }
    }
}
