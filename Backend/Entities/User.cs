using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApiCiCd.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore] public string Password { get; set; }
        public UserRole Role { get; set; }
        public string Address { get; set; }
        public string ResumeUrl { get; set; }
        public int WorkExperience { get; set; }
    }
}