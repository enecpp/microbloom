namespace microbloom.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; } // Örn: "Bilgisayar Mühendisliði"
        public required string ScoreType { get; set; } // Örn: "SAY", "EA", "SOZ"
     public double LastYearBaseScore { get; set; } // Geçen yýlki taban puan
        public int LastYearBaseRanking { get; set; } // Geçen yýlki taban sýralama

        // Ýliþki: Bu bölüm hangi üniversiteye ait? (Foreign Key)
        public int UniversityId { get; set; }
        public virtual University? University { get; set; }
 }
}
