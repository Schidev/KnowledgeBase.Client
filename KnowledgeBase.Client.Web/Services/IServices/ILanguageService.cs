using KnowledgeBase.Client.Web.Models.Base;
using KnowledgeBase.Client.Web.Models.Dictionary;

namespace KnowledgeBase.Client.Web.Services.IServices
{
    public interface ILanguageService
    {
        Task<ResponseDTO?> ReadLanguagesAsync();
        Task<ResponseDTO?> ReadLanguageAsync(Guid languageId);
        Task<ResponseDTO?> CreateLanguageAsync(LanguageDTO languageDTO);
        Task<ResponseDTO?> UpdateLanguageAsync(LanguageDTO languageDTO);
        Task<ResponseDTO?> DeleteLanguageAsync(Guid languageId);
    }
}