using KnowledgeBase.Client.Web.Models.Base;
using KnowledgeBase.Client.Web.Models.Dictionary;
using KnowledgeBase.Client.Web.Services.IServices;
using KnowledgeBase.Client.Web.Utility;

namespace KnowledgeBase.Client.Web.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IBaseService _baseService;
        public LanguageService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDTO?> ReadLanguagesAsync()
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.LanguagesAPIBase + "/api/Languages"
            });
        }
        public async Task<ResponseDTO?> ReadLanguageAsync(Guid languageId)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.LanguagesAPIBase + "/api/Languages/" + languageId.ToString()
            });
        }
        public async Task<ResponseDTO?> CreateLanguageAsync(LanguageDTO languageDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = languageDTO,
                Url = StaticDetails.LanguagesAPIBase + "/api/Languages"
            });
        }
        public async Task<ResponseDTO?> UpdateLanguageAsync(LanguageDTO languageDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = languageDTO,
                Url = StaticDetails.LanguagesAPIBase + "/api/Languages"
            });
        }
        public async Task<ResponseDTO?> DeleteLanguageAsync(Guid languageId)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = StaticDetails.LanguagesAPIBase + "/api/Languages/" + languageId.ToString()
            });
        }
    }
}
