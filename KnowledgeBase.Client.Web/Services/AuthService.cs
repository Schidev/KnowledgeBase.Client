using KnowledgeBase.Client.Web.Models.Auth;
using KnowledgeBase.Client.Web.Models.Base;
using KnowledgeBase.Client.Web.Services.IServices;
using KnowledgeBase.Client.Web.Utility;

namespace KnowledgeBase.Client.Web.Services
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;
        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDTO> LoginAsync(LoginRequestDTO loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = loginRequestDto,
                Url = StaticDetails.AuthAPIBase + "/api/auth/Login"
            });
        }

        public async Task<ResponseDTO> RegisterAsync(RegistrationRequestDTO registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = registrationRequestDto,
                Url = StaticDetails.AuthAPIBase + "/api/auth/Register"
            });
        }
        public async Task<ResponseDTO> AssignRoleAsync(RegistrationRequestDTO registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = registrationRequestDto,
                Url = StaticDetails.AuthAPIBase + "/api/auth/AssignRole"
            });
        }
    }
}
