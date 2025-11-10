using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace microbloom.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    LogoUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Slug = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CvSamples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    FileDownloadUrl = table.Column<string>(type: "TEXT", nullable: false),
                    ThumbnailImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvSamples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    IsStateUniversity = table.Column<bool>(type: "INTEGER", nullable: false),
                    LogoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    WebSite = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "JobPostings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    PostedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Slug = table.Column<string>(type: "TEXT", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    ContentCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentArticles_ContentCategories_ContentCategoryId",
                        column: x => x.ContentCategoryId,
                        principalTable: "ContentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ScoreType = table.Column<string>(type: "TEXT", nullable: false),
                    LastYearBaseScore = table.Column<double>(type: "REAL", nullable: false),
                    LastYearBaseRanking = table.Column<int>(type: "INTEGER", nullable: false),
                    UniversityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobPostingId = table.Column<int>(type: "INTEGER", nullable: false),
                    AppUserId = table.Column<string>(type: "TEXT", nullable: true),
                    ApplicationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplications_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobApplications_JobPostings_JobPostingId",
                        column: x => x.JobPostingId,
                        principalTable: "JobPostings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Description", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Global teknoloji lideri.", "google.png", "Google" },
                    { 2, "Yazılım ve bulut çözümleri.", "microsoft.png", "Microsoft" }
                });

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
                table: "Universities",
                columns: new[] { "Id", "City", "IsStateUniversity", "LogoUrl", "Name", "WebSite" },
                values: new object[,]
                {
                    { 1, "İstanbul", true, null, "İstanbul Teknik Üniversitesi", "https://itu.edu.tr" },
                    { 2, "İstanbul", true, null, "Boğaziçi Üniversitesi", "https://boun.edu.tr" },
                    { 3, "Ankara", true, null, "Orta Doğu Teknik Üniversitesi", "https://metu.edu.tr" },
                    { 4, "İstanbul", false, null, "Sabancı Üniversitesi", "https://sabanciuniv.edu" },
                    { 5, "İstanbul", false, null, "Koç Üniversitesi", "https://ku.edu.tr" }
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

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CompanyId", "Description", "IsActive", "Location", "PostedDate", "Title" },
                values: new object[,]
                {
                    { 1, 2, "ASP.NET Core ve Azure konusunda deneyimli...", true, "İstanbul", new DateTime(2025, 11, 9, 0, 49, 44, 367, DateTimeKind.Utc).AddTicks(9939), "Kıdemli .NET Geliştiricisi" },
                    { 2, 1, "React ve TypeScript bilen...", true, "Ankara", new DateTime(2025, 11, 9, 0, 49, 44, 367, DateTimeKind.Utc).AddTicks(9942), "Frontend Geliştirici (React)" },
                    { 3, 2, "CI/CD süreçlerine hakim...", true, "İstanbul", new DateTime(2025, 11, 9, 0, 49, 44, 367, DateTimeKind.Utc).AddTicks(9984), "DevOps Mühendisi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentArticles_ContentCategoryId",
                table: "ContentArticles",
                column: "ContentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UniversityId",
                table: "Departments",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_AppUserId",
                table: "JobApplications",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobPostingId",
                table: "JobApplications",
                column: "JobPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_CompanyId",
                table: "JobPostings",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContentArticles");

            migrationBuilder.DropTable(
                name: "CvSamples");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ContentCategories");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "JobPostings");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
