using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace microbloom.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTurkishUniversities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CvSamples",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CvSamples",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CvSamples",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CvSamples",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CvSamples",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "WebSite" },
                values: new object[] { "İstanbul Üniversitesi", "https://istanbul.edu.tr" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "WebSite" },
                values: new object[] { "İstanbul Teknik Üniversitesi", "https://itu.edu.tr" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "WebSite" },
                values: new object[] { "İstanbul", "Boğaziçi Üniversitesi", "https://boun.edu.tr" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsStateUniversity", "Name", "WebSite" },
                values: new object[] { true, "Marmara Üniversitesi", "https://marmara.edu.tr" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsStateUniversity", "Name", "WebSite" },
                values: new object[] { true, "Yıldız Teknik Üniversitesi", "https://yildiz.edu.tr" });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "City", "IsStateUniversity", "LogoUrl", "Name", "WebSite" },
                values: new object[,]
                {
                    { 6, "İstanbul", true, null, "Galatasaray Üniversitesi", "https://gsu.edu.tr" },
                    { 7, "Ankara", true, null, "Ankara Üniversitesi", "https://ankara.edu.tr" },
                    { 8, "Ankara", true, null, "Orta Doğu Teknik Üniversitesi", "https://metu.edu.tr" },
                    { 9, "Ankara", true, null, "Hacettepe Üniversitesi", "https://hacettepe.edu.tr" },
                    { 10, "Ankara", true, null, "Gazi Üniversitesi", "https://gazi.edu.tr" },
                    { 11, "Ankara", true, null, "Ankara Yıldırım Beyazıt Üniversitesi", "https://ybu.edu.tr" },
                    { 12, "İzmir", true, null, "Ege Üniversitesi", "https://ege.edu.tr" },
                    { 13, "İzmir", true, null, "Dokuz Eylül Üniversitesi", "https://deu.edu.tr" },
                    { 14, "İzmir", true, null, "İzmir Yüksek Teknoloji Enstitüsü", "https://iyte.edu.tr" },
                    { 15, "İzmir", true, null, "İzmir Katip Çelebi Üniversitesi", "https://ikc.edu.tr" },
                    { 16, "Kayseri", true, null, "Erciyes Üniversitesi", "https://erciyes.edu.tr" },
                    { 17, "Konya", true, null, "Selçuk Üniversitesi", "https://selcuk.edu.tr" },
                    { 18, "Erzurum", true, null, "Atatürk Üniversitesi", "https://atauni.edu.tr" },
                    { 19, "Adana", true, null, "Çukurova Üniversitesi", "https://cu.edu.tr" },
                    { 20, "Antalya", true, null, "Akdeniz Üniversitesi", "https://akdeniz.edu.tr" },
                    { 21, "Samsun", true, null, "Ondokuz Mayıs Üniversitesi", "https://omu.edu.tr" },
                    { 22, "Trabzon", true, null, "Karadeniz Teknik Üniversitesi", "https://ktu.edu.tr" },
                    { 23, "Bursa", true, null, "Uludağ Üniversitesi", "https://uludag.edu.tr" },
                    { 24, "Eskişehir", true, null, "Anadolu Üniversitesi", "https://anadolu.edu.tr" },
                    { 25, "Denizli", true, null, "Pamukkale Üniversitesi", "https://pau.edu.tr" },
                    { 26, "Elazığ", true, null, "Fırat Üniversitesi", "https://firat.edu.tr" },
                    { 27, "Isparta", true, null, "Süleyman Demirel Üniversitesi", "https://sdu.edu.tr" },
                    { 28, "Gaziantep", true, null, "Gaziantep Üniversitesi", "https://gantep.edu.tr" },
                    { 29, "Sakarya", true, null, "Sakarya Üniversitesi", "https://sakarya.edu.tr" },
                    { 30, "Kocaeli", true, null, "Kocaeli Üniversitesi", "https://kocaeli.edu.tr" },
                    { 31, "İstanbul", false, null, "Koç Üniversitesi", "https://ku.edu.tr" },
                    { 32, "İstanbul", false, null, "Sabancı Üniversitesi", "https://sabanciuniv.edu" },
                    { 33, "İstanbul", false, null, "Bahçeşehir Üniversitesi", "https://bahcesehir.edu.tr" },
                    { 34, "İstanbul", false, null, "İstanbul Bilgi Üniversitesi", "https://bilgi.edu.tr" },
                    { 35, "İstanbul", false, null, "Özyeğin Üniversitesi", "https://ozyegin.edu.tr" },
                    { 36, "İstanbul", false, null, "Kadir Has Üniversitesi", "https://khas.edu.tr" },
                    { 37, "İstanbul", false, null, "Yeditepe Üniversitesi", "https://yeditepe.edu.tr" },
                    { 38, "İstanbul", false, null, "İstanbul Ticaret Üniversitesi", "https://ticaret.edu.tr" },
                    { 39, "İstanbul", false, null, "İstanbul Kültür Üniversitesi", "https://iku.edu.tr" },
                    { 40, "İstanbul", false, null, "Işık Üniversitesi", "https://isikun.edu.tr" },
                    { 41, "Ankara", false, null, "Bilkent Üniversitesi", "https://bilkent.edu.tr" },
                    { 42, "Ankara", false, null, "Atılım Üniversitesi", "https://atilim.edu.tr" },
                    { 43, "Ankara", false, null, "Başkent Üniversitesi", "https://baskent.edu.tr" },
                    { 44, "Ankara", false, null, "Çankaya Üniversitesi", "https://cankaya.edu.tr" },
                    { 45, "Ankara", false, null, "TOBB Ekonomi ve Teknoloji Üniversitesi", "https://etu.edu.tr" },
                    { 46, "İzmir", false, null, "İzmir Ekonomi Üniversitesi", "https://ieu.edu.tr" },
                    { 47, "İzmir", false, null, "Yaşar Üniversitesi", "https://yasar.edu.tr" },
                    { 48, "İstanbul", false, null, "Özyeğin Üniversitesi", "https://ozyegin.edu.tr" },
                    { 49, "Ankara", false, null, "TED Üniversitesi", "https://tedu.edu.tr" },
                    { 50, "İstanbul", false, null, "MEF Üniversitesi", "https://mef.edu.tr" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.InsertData(
                table: "CvSamples",
                columns: new[] { "Id", "Description", "FileDownloadUrl", "ThumbnailImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Üniversiteden yeni mezun olan bilgisayar mühendisleri için hazırlanmış profesyonel CV örneği.", "/samples/cv-bilgisayar-yeni-mezun.pdf", null, "Yeni Mezun Bilgisayar Mühendisi CV Örneği" },
                    { 2, "3-5 yıl deneyime sahip yazılım geliştiriciler için CV şablonu.", "/samples/cv-yazilim-deneyimli.pdf", null, "Deneyimli Yazılım Geliştirici CV Örneği" },
                    { 3, "İşletme bölümü mezunları için staj başvurularında kullanılabilecek CV örneği.", "/samples/cv-isletme-stajyer.pdf", null, "İşletme Mezunu Stajyer CV Örneği" },
                    { 4, "Mühendislik öğrencileri için hazırlanmış staj başvuru CV'si.", "/samples/cv-muhendislik-staj.pdf", null, "Mühendislik Öğrencisi Staj CV Örneği" },
                    { 5, "Orta ve üst düzey yönetici pozisyonları için profesyonel CV şablonu.", "/samples/cv-yonetici.pdf", null, "Yönetici Pozisyonu CV Örneği" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "LastYearBaseRanking", "LastYearBaseScore", "Name", "ScoreType", "UniversityId" },
                values: new object[,]
                {
                    { 1, 1250, 525.5, "Bilgisayar Mühendisliği", "SAY", 1 },
                    { 2, 1580, 520.29999999999995, "Elektrik-Elektronik Mühendisliği", "SAY", 1 },
                    { 3, 2100, 515.79999999999995, "Makine Mühendisliği", "SAY", 1 },
                    { 4, 980, 530.20000000000005, "Bilgisayar Mühendisliği", "SAY", 2 },
                    { 5, 3200, 495.5, "İşletme", "EA", 2 },
                    { 6, 4500, 485.30000000000001, "Psikoloji", "EA", 2 },
                    { 7, 1100, 528.70000000000005, "Bilgisayar Mühendisliği", "SAY", 3 },
                    { 8, 1850, 518.20000000000005, "Endüstri Mühendisliği", "SAY", 3 },
                    { 9, 1450, 522.5, "Bilgisayar Bilimi ve Mühendisliği", "SAY", 4 },
                    { 10, 2350, 512.29999999999995, "Endüstri Mühendisliği", "SAY", 4 },
                    { 11, 1320, 524.79999999999995, "Bilgisayar Mühendisliği", "SAY", 5 },
                    { 12, 3800, 490.19999999999999, "İşletme", "EA", 5 }
                });

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 1, 9, 1, 518, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 1, 9, 1, 518, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 1, 9, 1, 518, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "WebSite" },
                values: new object[] { "İstanbul Teknik Üniversitesi", "https://itu.edu.tr" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "WebSite" },
                values: new object[] { "Boğaziçi Üniversitesi", "https://boun.edu.tr" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "WebSite" },
                values: new object[] { "Ankara", "Orta Doğu Teknik Üniversitesi", "https://metu.edu.tr" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsStateUniversity", "Name", "WebSite" },
                values: new object[] { false, "Sabancı Üniversitesi", "https://sabanciuniv.edu" });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsStateUniversity", "Name", "WebSite" },
                values: new object[] { false, "Koç Üniversitesi", "https://ku.edu.tr" });
        }
    }
}
