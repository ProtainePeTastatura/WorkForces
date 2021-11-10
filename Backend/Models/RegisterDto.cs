using WebApiCiCd.Entities;

namespace WebApiCiCd.Models
{
    public class RegisterDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public string Address { get; set; } 
        public string ResumeUrl { get; set; } 
        public int WorkExperience { get; set; }
    }
}