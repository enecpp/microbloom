using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace microbloom.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentsToAllUniversities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "LastYearBaseRanking", "LastYearBaseScore", "Name", "ScoreType", "UniversityId" },
                values: new object[,]
                {
                    { 1, 1850, 520.5, "Hukuk", "EA", 1 },
                    { 2, 850, 545.20000000000005, "Tıp", "SAY", 1 },
                    { 3, 3200, 495.30000000000001, "İşletme", "EA", 1 },
                    { 4, 4500, 485.69999999999999, "Psikoloji", "EA", 1 },
                    { 5, 1250, 525.5, "Bilgisayar Mühendisliği", "SAY", 2 },
                    { 6, 1580, 520.29999999999995, "Elektrik-Elektronik Mühendisliği", "SAY", 2 },
                    { 7, 2100, 515.79999999999995, "Makine Mühendisliği", "SAY", 2 },
                    { 8, 2450, 512.39999999999998, "İnşaat Mühendisliği", "SAY", 2 },
                    { 9, 980, 530.20000000000005, "Bilgisayar Mühendisliği", "SAY", 3 },
                    { 10, 3200, 495.5, "İşletme", "EA", 3 },
                    { 11, 4500, 485.30000000000001, "Psikoloji", "EA", 3 },
                    { 12, 3800, 490.80000000000001, "Ekonomi", "EA", 3 },
                    { 13, 2350, 510.5, "Hukuk", "EA", 4 },
                    { 14, 1150, 535.79999999999995, "Tıp", "SAY", 4 },
                    { 15, 4200, 485.19999999999999, "İşletme", "EA", 4 },
                    { 16, 5100, 475.60000000000002, "İktisat", "EA", 4 },
                    { 17, 1750, 518.39999999999998, "Bilgisayar Mühendisliği", "SAY", 5 },
                    { 18, 2850, 505.19999999999999, "İnşaat Mühendisliği", "SAY", 5 },
                    { 19, 2650, 508.69999999999999, "Makine Mühendisliği", "SAY", 5 },
                    { 20, 2150, 515.29999999999995, "Hukuk", "EA", 6 },
                    { 21, 3450, 492.5, "İşletme", "EA", 6 },
                    { 22, 3900, 488.89999999999998, "Uluslararası İlişkiler", "EA", 6 },
                    { 23, 1650, 522.79999999999995, "Hukuk", "EA", 7 },
                    { 24, 920, 542.29999999999995, "Tıp", "SAY", 7 },
                    { 25, 4850, 495.69999999999999, "Veterinerlik", "SAY", 7 },
                    { 26, 3200, 510.19999999999999, "Eczacılık", "SAY", 7 },
                    { 27, 1100, 528.70000000000005, "Bilgisayar Mühendisliği", "SAY", 8 },
                    { 28, 1850, 518.20000000000005, "Endüstri Mühendisliği", "SAY", 8 },
                    { 29, 1450, 522.5, "Elektrik-Elektronik Mühendisliği", "SAY", 8 },
                    { 30, 2150, 515.29999999999995, "Makine Mühendisliği", "SAY", 8 },
                    { 31, 750, 548.5, "Tıp", "SAY", 9 },
                    { 32, 1650, 525.29999999999995, "Diş Hekimliği", "SAY", 9 },
                    { 33, 2250, 518.70000000000005, "Eczacılık", "SAY", 9 },
                    { 34, 3550, 492.39999999999998, "Psikoloji", "EA", 9 },
                    { 35, 1250, 535.20000000000005, "Tıp", "SAY", 10 },
                    { 36, 2650, 505.80000000000001, "Hukuk", "EA", 10 },
                    { 37, 2850, 508.39999999999998, "Bilgisayar Mühendisliği", "SAY", 10 },
                    { 38, 4850, 478.30000000000001, "İşletme", "EA", 10 },
                    { 39, 1050, 538.70000000000005, "Tıp", "SAY", 12 },
                    { 40, 1850, 520.5, "Diş Hekimliği", "SAY", 12 },
                    { 41, 2450, 512.79999999999995, "Eczacılık", "SAY", 12 },
                    { 42, 4350, 482.5, "İşletme", "EA", 12 },
                    { 43, 1350, 532.39999999999998, "Tıp", "SAY", 13 },
                    { 44, 2850, 502.69999999999999, "Hukuk", "EA", 13 },
                    { 45, 2950, 505.80000000000001, "Bilgisayar Mühendisliği", "SAY", 13 },
                    { 46, 5150, 475.39999999999998, "İşletme", "EA", 13 },
                    { 47, 2050, 515.70000000000005, "Bilgisayar Mühendisliği", "SAY", 14 },
                    { 48, 2750, 508.30000000000001, "Elektrik-Elektronik Mühendisliği", "SAY", 14 },
                    { 49, 3150, 502.60000000000002, "Makine Mühendisliği", "SAY", 14 },
                    { 50, 1450, 528.5, "Tıp", "SAY", 16 },
                    { 51, 2550, 512.29999999999995, "Diş Hekimliği", "SAY", 16 },
                    { 52, 3350, 495.80000000000001, "Hukuk", "EA", 16 },
                    { 53, 5450, 472.39999999999998, "İşletme", "EA", 16 },
                    { 54, 1550, 525.70000000000005, "Tıp", "SAY", 17 },
                    { 55, 3550, 492.5, "Hukuk", "EA", 17 },
                    { 56, 4250, 488.30000000000001, "Veterinerlik", "SAY", 17 },
                    { 57, 5850, 468.89999999999998, "İşletme", "EA", 17 },
                    { 58, 1320, 524.79999999999995, "Bilgisayar Mühendisliği", "SAY", 31 },
                    { 59, 3800, 490.19999999999999, "İşletme", "EA", 31 },
                    { 60, 2550, 508.5, "Hukuk", "EA", 31 },
                    { 61, 3250, 495.69999999999999, "Ekonomi", "EA", 31 },
                    { 62, 1450, 522.5, "Bilgisayar Bilimi ve Mühendisliği", "SAY", 32 },
                    { 63, 2350, 512.29999999999995, "Endüstri Mühendisliği", "SAY", 32 },
                    { 64, 3950, 488.60000000000002, "İşletme", "EA", 32 },
                    { 65, 3600, 492.30000000000001, "Ekonomi", "EA", 32 },
                    { 66, 2950, 505.39999999999998, "Bilgisayar Mühendisliği", "SAY", 33 },
                    { 67, 5050, 475.80000000000001, "İşletme", "EA", 33 },
                    { 68, 3950, 488.5, "Hukuk", "EA", 33 },
                    { 69, 3850, 495.19999999999999, "Mimarlık", "SAY", 33 },
                    { 70, 1280, 526.5, "Bilgisayar Mühendisliği", "SAY", 41 },
                    { 71, 3250, 495.80000000000001, "İşletme", "EA", 41 },
                    { 72, 2450, 510.39999999999998, "Hukuk", "EA", 41 },
                    { 73, 2850, 502.69999999999999, "Uluslararası İlişkiler", "EA", 41 },
                    { 74, 1380, 530.5, "Tıp", "SAY", 20 },
                    { 75, 2150, 515.79999999999995, "Diş Hekimliği", "SAY", 20 },
                    { 76, 3350, 495.39999999999998, "Hukuk", "EA", 20 },
                    { 77, 5150, 475.19999999999999, "İşletme", "EA", 20 },
                    { 78, 1450, 528.29999999999995, "Tıp", "SAY", 19 },
                    { 79, 2550, 512.5, "Diş Hekimliği", "SAY", 19 },
                    { 80, 3850, 492.69999999999999, "Veterinerlik", "SAY", 19 },
                    { 81, 6250, 468.5, "Ziraat Mühendisliği", "SAY", 19 }
                });

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 17, 1, 12, 898, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 17, 1, 12, 898, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 17, 1, 12, 898, DateTimeKind.Utc).AddTicks(7126));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 15, 15, 11, 499, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 15, 15, 11, 499, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 15, 15, 11, 499, DateTimeKind.Utc).AddTicks(9922));
        }
    }
}
