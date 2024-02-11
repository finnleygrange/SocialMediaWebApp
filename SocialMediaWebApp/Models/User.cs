using System.ComponentModel.DataAnnotations;

namespace SocialMediaWebApp.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailConfirmed { get; set; }
        public string PhoneConfirmed { get; set; }
    }
}
