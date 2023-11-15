using static KnowledgeBase.Client.Web.Utility.StaticDetails;

namespace KnowledgeBase.Client.Web.Models.Base
{
    public class RequestDTO
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}