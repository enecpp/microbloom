using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace microbloom.Migrations
{
    /// <inheritdoc />
    public partial class AddRealContentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContentCategories",
                columns: new[] { "Id", "Slug", "Title" },
                values: new object[,]
                {
                    { 1, "universiteye-hazirlik", "Üniversiteye Hazırlık" },
                    { 2, "profesyonel-hayat", "İlk İşim ve Profesyonel Hayat" }
                });

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 0, 55, 44, 856, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 0, 55, 44, 856, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 0, 55, 44, 856, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.InsertData(
                table: "ContentArticles",
                columns: new[] { "Id", "Content", "ContentCategoryId", "Slug", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "# &#x1F393; Üniversite Seçimi Rehberi\r\n\r\nÜniversite seçimi, hayatınızın en önemli kararlarından biridir. İşte doğru tercih yapmanız için ipuçları:\r\n\r\n## &#x1F4D6; 1. Bölüm Seçimi\r\n- &#x2714; İlgi alanlarınızı ve yeteneklerinizi değerlendirin\r\n- &#x2714; Bölümün kariyer olanaklarını araştırın\r\n- &#x2714; Sektördeki iş imkanlarını inceleyin\r\n\r\n## &#x1F3EB; 2. Üniversite Kriterleri\r\n- &#x1F4DA; Akademik kadro kalitesi\r\n- &#x1F3C6; Kampüs imkanları ve sosyal aktiviteler\r\n- &#x1F30D; Uluslararası değişim programları\r\n- &#x1F4BC; Mezun memnuniyeti ve kariyer desteği\r\n\r\n## &#x1F3D9; 3. Şehir Seçimi\r\n- &#x1F4B5; Yaşam maliyeti\r\n- &#x1F3AD; Kültürel ve sosyal olanaklar\r\n- &#x1F3E2; İş bulma imkanları\r\n- &#x1F3E0; Ailenize uzaklık\r\n\r\n## &#x1F4CA; 4. Taban Puan ve Sıralama\r\n- &#x2705; Gerçekçi hedefler belirleyin\r\n- &#x1F4DD; Yedek tercihlerinizi mutlaka doldurun\r\n- &#x1F4C8; Önceki yılların yerleştirme puanlarını inceleyin", 1, "universite-secimi-rehberi", "Üniversite seçerken nelere dikkat etmelisiniz? Şehir, bölüm, taban puan ve kariyer hedeflerinize göre doğru tercih nasıl yapılır?", "Üniversite Seçimi Rehberi" },
                    { 2, "# &#x1F4BB; Mühendislik Bölümleri Rehberi\r\n\r\n## &#x1F5A5; Bilgisayar Mühendisliği\r\nYazılım geliştirme, veri bilimi, yapay zeka gibi alanlarda çalışma fırsatı sunar.\r\n\r\n**Kariyer Alanları:**\r\n- &#x1F4BB; Yazılım Geliştirici\r\n- &#x1F4CA; Veri Analisti / Data Scientist\r\n- &#x1F3D7; Sistem Mimarı\r\n- &#x2699; DevOps Mühendisi\r\n\r\n**Başlangıç Maaşları:** &#x1F4B0; 25.000 - 40.000 TL\r\n\r\n## &#x26A1; Elektrik-Elektronik Mühendisliği\r\nElektronik sistemler, güç sistemleri, telekomünikasyon alanlarında uzmanlaşma.\r\n\r\n**Kariyer Alanları:**\r\n- &#x1F50C; Elektronik Tasarım Mühendisi\r\n- &#x1F4A1; Enerji Sistemleri Uzmanı\r\n- &#x1F4E1; Telekomünikasyon Mühendisi\r\n\r\n## &#x2699; Endüstri Mühendisliği\r\nÜretim süreçlerinin optimizasyonu, lojistik ve proje yönetimi.\r\n\r\n**Kariyer Alanları:**\r\n- &#x1F4C8; Proje Yöneticisi\r\n- &#x1F69A; Lojistik Uzmanı\r\n- &#x1F504; Süreç Geliştirme Mühendisi", 1, "bolum-rehberi-muhendislik", "Mühendislik bölümleri hakkında her şey: Hangi bölüm size uygun? Kariyer olanakları neler? Mezuniyet sonrası ne yapabilirsiniz?", "Bölüm Rehberi: Mühendislik" },
                    { 3, "# &#x1F4B0; Burs ve Mali Destek Rehberi\r\n\r\n## &#x1F3DB; Devlet Bursu\r\n- &#x1F393; YÖK bursu\r\n- &#x1F3E0; Kredi Yurtlar Kurumu (KYK)\r\n- &#x1F3C6; Başarı bursu\r\n\r\n## &#x1F3E2; Özel Kuruluş Bursları\r\n- &#x1F4DA; Vakıf üniversiteleri tam burs programları\r\n- &#x1F4BC; Özel sektör şirket bursları (TÜBİTAK, TÜSİAD)\r\n- &#x1F3DB; Belediye bursları\r\n\r\n## &#x1F4DD; Başvuru İpuçları\r\n1. &#x1F4C5; Başvuru tarihlerini takip edin\r\n2. &#x1F4C4; Gereken belgeleri önceden hazırlayın\r\n3. &#x270D; Motivasyon mektubunuza özen gösterin\r\n4. &#x1F4E8; Birden fazla burs programına başvurun\r\n\r\n## &#x1F517; Önemli Linkler\r\n- turkiye.gov.tr/kyk-ogrenci-kredisi\r\n- yok.gov.tr", 1, "burs-mali-destek", "Üniversite eğitiminiz için burs ve mali destek alma yolları. Hangi kuruluşlar burs veriyor? Başvuru şartları neler?", "Burs ve Mali Destek İmkanları" },
                    { 4, "# &#x1F4C4; CV Hazırlama Rehberi\r\n\r\n## &#x2705; CV'de Olması Gerekenler\r\n\r\n### 1. &#x1F464; Kişisel Bilgiler\r\n- &#x1F4DD; Ad Soyad\r\n- &#x1F4DE; İletişim Bilgileri (Telefon, E-posta)\r\n- &#x1F517; LinkedIn Profili\r\n- &#x1F4BB; GitHub (yazılımcılar için)\r\n\r\n### 2. &#x1F4AC; Özet\r\n2-3 cümlelik kısa bir özet ile kendinizi tanıtın.\r\n\r\n**Örnek:** \"Bilgisayar Mühendisliği mezunu, 2 yıllık web geliştirme deneyimi. React ve Node.js teknolojilerinde uzman.\"\r\n\r\n### 3. &#x1F393; Eğitim\r\n- &#x1F3DB; Üniversite adı ve bölüm\r\n- &#x1F4C5; Mezuniyet tarihi\r\n- &#x1F4CA; Not ortalaması (3.00 üzerindeyse)\r\n\r\n### 4. &#x1F4BC; İş Deneyimi\r\n- &#x1F3E2; Şirket adı ve pozisyon\r\n- &#x1F4C6; Çalışma tarihleri\r\n- &#x2705; Görev ve başarılarınız\r\n- &#x1F6E0; Kullandığınız teknolojiler\r\n\r\n### 5. &#x1F680; Projeler\r\n- &#x1F4BB; Kişisel veya okul projeleri\r\n- &#x1F310; Açık kaynak katkılarınız\r\n\r\n### 6. &#x2B50; Beceriler\r\n- &#x1F4DA; Programlama dilleri\r\n- &#x1F527; Araçlar ve teknolojiler\r\n- &#x1F30D; Yabancı dil seviyeleri\r\n\r\n## &#x1F4A1; CV Hazırlama İpuçları\r\n- &#x1F4C4; Maksimum 2 sayfa olmalı\r\n- &#x1F3AF; Özgeçmişinizi her pozisyon için özelleştirin\r\n- &#x1F4CA; Somut başarılarınızı sayılarla destekleyin\r\n- &#x2705; Yazım hatalarından kaçının", 2, "cv-hazirlama-rehberi", "Profesyonel bir CV nasıl hazırlanır? İşverenin dikkatini çekecek CV örnekleri ve ipuçları.", "CV Hazırlama Rehberi" },
                    { 5, "# &#x1F3AF; İş Görüşmesine Hazırlık\r\n\r\n## &#x1F4C5; Görüşme Öncesi\r\n1. &#x1F50D; Şirket hakkında araştırma yapın\r\n2. &#x1F4DD; Pozisyon tanımını detaylı inceleyin\r\n3. &#x1F4AC; Kendinizi tanıtma pratiği yapın\r\n4. &#x1F454; Şık ve profesyonel giyinin\r\n\r\n## &#x2753; Sık Sorulan Sorular\r\n\r\n### \"Kendinizden bahseder misiniz?\"\r\n- &#x23F1; Kısa ve öz olun\r\n- &#x1F393; Eğitim ve deneyimlerinize değinin\r\n- &#x1F3AF; Neden bu pozisyona uygun olduğunuzu vurgulayın\r\n\r\n### \"Güçlü yönleriniz neler?\"\r\n- &#x1F4AA; Pozisyonla ilgili güçlü yönlerinizi seçin\r\n- &#x1F4A1; Somut örneklerle destekleyin\r\n\r\n### \"Zayıf yönleriniz?\"\r\n- &#x1F91D; Dürüst olun ama kendinizi kötülemeyin\r\n- &#x1F4C8; Nasıl geliştirmeye çalıştığınızı anlatın\r\n\r\n### \"5 yıl sonra kendinizi nerede görüyorsunuz?\"\r\n- &#x1F680; Kariyer hedeflerinizden bahsedin\r\n- &#x1F3E2; Şirketle birlikte büyümek istediğinizi belirtin\r\n\r\n## &#x1F4E7; Görüşme Sonrası\r\n- &#x1F64F; Teşekkür e-postası gönderin\r\n- &#x23F0; Geri dönüş süresini sorun\r\n- &#x1F9D8; Sabırlı olun", 2, "is-gorusmesine-hazirlik", "İş görüşmesinde başarılı olmanın püf noktaları. Sık sorulan sorular ve nasıl cevaplanır?", "İş Görüşmesine Hazırlık" },
                    { 6, "# &#x1F680; Staj ve İş Bulma Stratejileri\r\n\r\n## &#x1F310; İş Arama Platformları\r\n1. **LinkedIn** - &#x1F465; Profesyonel networking\r\n2. **Kariyer.net** - &#x1F4BC; İş ilanları\r\n3. **SecretCV** - &#x1F575; Anonim başvuru\r\n4. **GitHub Jobs** - &#x1F4BB; Yazılım pozisyonları\r\n5. **AngelList** - &#x1F680; Startup'lar\r\n\r\n## &#x1F91D; Networking İpuçları\r\n- &#x1F4C8; LinkedIn profilinizi güncel tutun\r\n- &#x1F3AA; Sektör etkinliklerine katılın\r\n- &#x1F393; Üniversite mezunları ağınızı kullanın\r\n- &#x1F468;&#x1F3EB; Mentorluk programlarına başvurun\r\n\r\n## &#x1F4BC; Staj Başvurusu\r\n- **Ne zaman başvurmalı?** \r\n  &#x2600; Yazın staj için 3-4 ay önce başlayın\r\n  \r\n- **Başvuru mektubu yazın**\r\n  &#x270D; Neden o şirkette çalışmak istediğinizi açıklayın\r\n\r\n- **Portföy hazırlayın**\r\n  &#x1F4BB; GitHub projeleri, kişisel web sitesi\r\n\r\n## &#x1F3AF; İlk İş İçin İpuçları\r\n- &#x1F4B0; Maaş beklentinizi araştırın\r\n- &#x1F3E2; Şirket kültürüne dikkat edin\r\n- &#x1F4C8; Gelişim fırsatlarını değerlendirin\r\n- &#x23F3; İlk işinizde 1-2 yıl kalın", 2, "staj-is-bulma", "İlk stajınızı veya işinizi nasıl bulursunuz? Hangi platformları kullanmalısınız? Networking nasıl yapılır?", "Staj ve İş Bulma Stratejileri" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentArticles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContentArticles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContentArticles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContentArticles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContentArticles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ContentArticles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 0, 49, 44, 367, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 0, 49, 44, 367, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2025, 11, 9, 0, 49, 44, 367, DateTimeKind.Utc).AddTicks(9984));
        }
    }
}
