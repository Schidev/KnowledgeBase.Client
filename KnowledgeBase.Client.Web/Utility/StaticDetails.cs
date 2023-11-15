namespace KnowledgeBase.Client.Web.Utility
{
    public class StaticDetails
    {
        public static string LanguagesAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}