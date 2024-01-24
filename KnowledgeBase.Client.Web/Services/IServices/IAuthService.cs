using KnowledgeBase.Client.Web.Models.Auth;
using KnowledgeBase.Client.Web.Models.Base;

namespace KnowledgeBase.Client.Web.Services.IServices
{
    public interface IAuthService
    {
        Task<ResponseDTO?> LoginAsync(LoginRequestDTO loginRequestDto);
        Task<ResponseDTO?> RegisterAsync(RegistrationRequestDTO registrationRequestDto);
        Task<ResponseDTO?> AssignRoleAsync(RegistrationRequestDTO registrationRequestDto);
    }
}