using System.ComponentModel.DataAnnotations;

namespace KnowledgeBase.Client.Web.Models.Auth
{
    public class LoginRequestDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}