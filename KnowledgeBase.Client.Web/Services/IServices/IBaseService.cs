using KnowledgeBase.Client.Web.Models.Base;

namespace KnowledgeBase.Client.Web.Services.IServices
{
    public interface IBaseService
    {
        Task<ResponseDTO?> SendAsync(RequestDTO requestDto);
    }
}
