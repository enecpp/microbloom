using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace microbloom.Migrations
{
    /// <inheritdoc />
    public partial class AddAllUniversityDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "LastYearBaseRanking", "LastYearBaseScore", "Name", "ScoreType", "UniversityId" },
                values: new object[,]
                {
                    { 82, 1480, 526.79999999999995, "Tıp", "SAY", 21 },
                    { 83, 2650, 510.5, "Diş Hekimliği", "SAY", 21 },
                    { 84, 3950, 490.30000000000001, "Veterinerlik", "SAY", 21 },
                    { 85, 6050, 470.19999999999999, "Ziraat Mühendisliği", "SAY", 21 },
                    { 86, 1420, 528.5, "Tıp", "SAY", 22 },
                    { 87, 3050, 502.80000000000001, "İnşaat Mühendisliği", "SAY", 22 },
                    { 88, 2950, 505.39999999999998, "Elektrik-Elektronik Mühendisliği", "SAY", 22 },
                    { 89, 3250, 500.60000000000002, "Makine Mühendisliği", "SAY", 22 },
                    { 90, 1350, 530.20000000000005, "Tıp", "SAY", 23 },
                    { 91, 2450, 512.70000000000005, "Diş Hekimliği", "SAY", 23 },
                    { 92, 3750, 492.5, "Veterinerlik", "SAY", 23 },
                    { 93, 4950, 476.80000000000001, "İşletme", "EA", 23 },
                    { 94, 1450, 527.5, "Tıp", "SAY", 24 },
                    { 95, 2750, 508.39999999999998, "Eczacılık", "SAY", 24 },
                    { 96, 4750, 478.5, "İşletme", "EA", 24 },
                    { 97, 5350, 472.30000000000001, "İktisat", "EA", 24 },
                    { 98, 1550, 525.79999999999995, "Tıp", "SAY", 25 },
                    { 99, 2750, 508.5, "Diş Hekimliği", "SAY", 25 },
                    { 100, 3650, 495.69999999999999, "Bilgisayar Mühendisliği", "SAY", 25 },
                    { 101, 5550, 470.5, "İşletme", "EA", 25 },
                    { 102, 1750, 522.5, "Tıp", "SAY", 26 },
                    { 103, 2950, 505.80000000000001, "Diş Hekimliği", "SAY", 26 },
                    { 104, 4350, 485.39999999999998, "Veterinerlik", "SAY", 26 },
                    { 105, 3950, 488.5, "Hukuk", "EA", 26 },
                    { 106, 1520, 526.29999999999995, "Tıp", "SAY", 27 },
                    { 107, 2650, 510.19999999999999, "Diş Hekimliği", "SAY", 27 },
                    { 108, 3650, 495.80000000000001, "Mimarlık", "SAY", 27 },
                    { 109, 5350, 472.69999999999999, "İşletme", "EA", 27 },
                    { 110, 1650, 524.5, "Tıp", "SAY", 28 },
                    { 111, 2750, 508.69999999999999, "Diş Hekimliği", "SAY", 28 },
                    { 112, 3750, 490.5, "Hukuk", "EA", 28 },
                    { 113, 5750, 468.80000000000001, "İşletme", "EA", 28 },
                    { 114, 1480, 526.79999999999995, "Tıp", "SAY", 29 },
                    { 115, 2650, 510.5, "Diş Hekimliği", "SAY", 29 },
                    { 116, 3150, 502.39999999999998, "Bilgisayar Mühendisliği", "SAY", 29 },
                    { 117, 5050, 475.30000000000001, "İşletme", "EA", 29 },
                    { 118, 1420, 528.20000000000005, "Tıp", "SAY", 30 },
                    { 119, 2450, 512.5, "Diş Hekimliği", "SAY", 30 },
                    { 120, 2950, 505.80000000000001, "Bilgisayar Mühendisliği", "SAY", 30 },
                    { 121, 4950, 476.5, "İşletme", "EA", 30 },
                    { 122, 2850, 502.5, "Hukuk", "EA", 34 },
                    { 123, 4150, 485.80000000000001, "İşletme", "EA", 34 },
                    { 124, 4450, 482.5, "Psikoloji", "EA", 34 },
                    { 125, 3850, 488.69999999999999, "Uluslararası İlişkiler", "EA", 34 },
                    { 126, 2050, 515.79999999999995, "Bilgisayar Mühendisliği", "SAY", 35 },
                    { 127, 2750, 508.5, "Endüstri Mühendisliği", "SAY", 35 },
                    { 128, 4250, 485.39999999999998, "İşletme", "EA", 35 },
                    { 129, 3350, 495.80000000000001, "Hukuk", "EA", 35 },
                    { 130, 3350, 495.5, "Hukuk", "EA", 36 },
                    { 131, 4750, 478.80000000000001, "İşletme", "EA", 36 },
                    { 132, 3150, 502.5, "Endüstri Mühendisliği", "SAY", 36 },
                    { 133, 2950, 505.80000000000001, "Bilgisayar Mühendisliği", "SAY", 36 },
                    { 134, 1150, 535.5, "Tıp", "SAY", 37 },
                    { 135, 1950, 518.79999999999995, "Diş Hekimliği", "SAY", 37 },
                    { 136, 3150, 498.5, "Hukuk", "EA", 37 },
                    { 137, 4450, 482.69999999999999, "İşletme", "EA", 37 },
                    { 138, 5050, 475.5, "İşletme", "EA", 38 },
                    { 139, 5350, 472.80000000000001, "Uluslararası Ticaret", "EA", 38 },
                    { 140, 5750, 468.5, "İktisat", "EA", 38 },
                    { 141, 3750, 495.39999999999998, "Bilgisayar Mühendisliği", "SAY", 38 },
                    { 142, 4250, 485.5, "Hukuk", "EA", 39 },
                    { 143, 5350, 472.80000000000001, "İşletme", "EA", 39 },
                    { 144, 4150, 488.5, "Mimarlık", "SAY", 39 },
                    { 145, 3850, 492.69999999999999, "Bilgisayar Mühendisliği", "SAY", 39 },
                    { 146, 4750, 478.5, "İşletme", "EA", 40 },
                    { 147, 3450, 498.80000000000001, "Bilgisayar Mühendisliği", "SAY", 40 },
                    { 148, 3650, 495.5, "Endüstri Mühendisliği", "SAY", 40 },
                    { 149, 5350, 472.5, "İktisat", "EA", 40 },
                    { 150, 2950, 505.80000000000001, "Bilgisayar Mühendisliği", "SAY", 42 },
                    { 151, 3450, 498.5, "Endüstri Mühendisliği", "SAY", 42 },
                    { 152, 5050, 475.80000000000001, "İşletme", "EA", 42 },
                    { 153, 3950, 488.5, "Hukuk", "EA", 42 },
                    { 154, 1280, 532.5, "Tıp", "SAY", 43 },
                    { 155, 2150, 515.79999999999995, "Diş Hekimliği", "SAY", 43 },
                    { 156, 3650, 492.5, "Hukuk", "EA", 43 },
                    { 157, 4750, 478.80000000000001, "İşletme", "EA", 43 },
                    { 158, 3150, 502.5, "Bilgisayar Mühendisliği", "SAY", 44 },
                    { 159, 3650, 495.80000000000001, "Endüstri Mühendisliği", "SAY", 44 },
                    { 160, 5350, 472.5, "İşletme", "EA", 44 },
                    { 161, 4050, 488.69999999999999, "Mimarlık", "SAY", 44 },
                    { 162, 2450, 512.5, "Bilgisayar Mühendisliği", "SAY", 45 },
                    { 163, 2950, 505.80000000000001, "Endüstri Mühendisliği", "SAY", 45 },
                    { 164, 4250, 485.5, "İşletme", "EA", 45 },
                    { 165, 4450, 482.80000000000001, "Ekonomi", "EA", 45 },
                    { 166, 4450, 482.5, "İşletme", "EA", 46 },
                    { 167, 4750, 478.80000000000001, "Uluslararası İlişkiler", "EA", 46 },
                    { 168, 3450, 498.5, "Bilgisayar Mühendisliği", "SAY", 46 },
                    { 169, 3850, 492.69999999999999, "Mimarlık", "SAY", 46 },
                    { 170, 5050, 475.80000000000001, "İşletme", "EA", 47 },
                    { 171, 3650, 495.5, "Bilgisayar Mühendisliği", "SAY", 47 },
                    { 172, 3850, 492.80000000000001, "Endüstri Mühendisliği", "SAY", 47 },
                    { 173, 4050, 488.5, "Mimarlık", "SAY", 47 },
                    { 174, 2750, 508.5, "Bilgisayar Mühendisliği", "SAY", 49 },
                    { 175, 3150, 502.80000000000001, "Endüstri Mühendisliği", "SAY", 49 },
                    { 176, 4750, 478.5, "İşletme", "EA", 49 },
                    { 177, 5050, 475.80000000000001, "Psikoloji", "EA", 49 },
                    { 178, 3150, 502.5, "Bilgisayar Mühendisliği", "SAY", 50 },
                    { 179, 3650, 495.80000000000001, "Endüstri Mühendisliği", "SAY", 50 },
                    { 180, 5050, 475.5, "İşletme", "EA", 50 },
                    { 181, 5350, 472.80000000000001, "Ekonomi", "EA", 50 },
                    { 182, 1280, 532.5, "Tıp", "SAY", 11 },
                    { 183, 2850, 502.80000000000001, "Hukuk", "EA", 11 },
                    { 184, 4750, 478.5, "İşletme", "EA", 11 },
                    { 185, 2950, 505.80000000000001, "Bilgisayar Mühendisliği", "SAY", 11 },
                    { 186, 1550, 525.79999999999995, "Tıp", "SAY", 15 },
                    { 187, 2750, 508.5, "Diş Hekimliği", "SAY", 15 },
                    { 188, 5350, 472.5, "İşletme", "EA", 15 },
                    { 189, 4050, 488.69999999999999, "Mimarlık", "SAY", 15 },
                    { 190, 1420, 528.5, "Tıp", "SAY", 18 },
                    { 191, 2650, 510.80000000000001, "Diş Hekimliği", "SAY", 18 },
                    { 192, 3950, 490.5, "Veterinerlik", "SAY", 18 },
                    { 193, 2750, 508.69999999999999, "Eczacılık", "SAY", 18 }
                });

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 17, 12, 31, 240, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 17, 12, 31, 240, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 17, 12, 31, 240, DateTimeKind.Utc).AddTicks(5872));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 193);

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
    }
}
