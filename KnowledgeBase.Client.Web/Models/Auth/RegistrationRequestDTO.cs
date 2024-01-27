using System.ComponentModel.DataAnnotations;

namespace KnowledgeBase.Client.Web.Models.Auth
{
    public class RegistrationRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; } = "User";
    }
}