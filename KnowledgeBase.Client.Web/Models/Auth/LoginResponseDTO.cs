namespace KnowledgeBase.Client.Web.Models.Auth
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}