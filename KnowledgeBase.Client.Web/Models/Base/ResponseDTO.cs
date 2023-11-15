namespace KnowledgeBase.Client.Web.Models.Base
{
    public class ResponseDTO
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = String.Empty;
    }
}