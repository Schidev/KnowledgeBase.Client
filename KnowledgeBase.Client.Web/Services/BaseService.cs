using KnowledgeBase.Client.Web.Models.Base;
using KnowledgeBase.Client.Web.Services.IServices;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using static KnowledgeBase.Client.Web.Utility.StaticDetails;

namespace KnowledgeBase.Client.Web.Services
{
    public class BaseService : IBaseService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public BaseService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;


        public async Task<ResponseDTO?> SendAsync(RequestDTO requestDto)
        {
            try
            {
                var _httpClient = _httpClientFactory.CreateClient("KnowledgeBaseAPI");

                HttpRequestMessage message = new();

                message.Headers.Add("Accept", "application/json");
                //token

                message.RequestUri = new Uri(requestDto.Url);

                if (requestDto.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(requestDto.Data), Encoding.UTF8, "application/json");
                }

                HttpResponseMessage? apiResponse = null;

                switch (requestDto.ApiType)
                {
                    case ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    case ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                apiResponse = await _httpClient.SendAsync(message);

                switch (apiResponse.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        return new() { IsSuccess = false, Message = "Not Found" };
                    case HttpStatusCode.Forbidden:
                        return new() { IsSuccess = false, Message = "Access Denied" };
                    case HttpStatusCode.Unauthorized:
                        return new() { IsSuccess = false, Message = "Unauthorized" };
                    case HttpStatusCode.InternalServerError:
                        return new() { IsSuccess = false, Message = "Internal Server Error" };
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        var apiResponseDto = JsonConvert.DeserializeObject<ResponseDTO>(apiContent);
                        return apiResponseDto;
                }

            }
            catch (Exception exception)
            {
                var dto = new ResponseDTO
                {
                    Message = exception.Message.ToString(),
                    IsSuccess = false
                };
                return dto;
            }
        }
    }
}
