using Microsoft.AspNetCore.Identity;

namespace microbloom.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<JobApplication>? Applications { get; set; } 


    }   

    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? LogoUrl { get; set; }
        public ICollection<JobPosting>? JobPostings { get; set; } 
    }

    public class JobPosting
    {
        public int Id { get; set; } 
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public DateTime PostedDate { get; set; }

        public bool IsActive { get; set; }

        public int CompanyId { get; set; }

        public Company? Company { get; set; }
    }

    public class JobApplication
    {
        public int Id { get; set; } 

        public int JobPostingId { get; set; }

        public JobPosting? JobPosting { get; set; }  

        public string? AppUserId { get; set; }   

        public AppUser? AppUser { get; set; }    

        public DateTime ApplicationDate { get; set; }   

        public string? Status { get; set; }  

    }
}