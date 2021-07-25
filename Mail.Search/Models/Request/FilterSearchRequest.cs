namespace Mail.Search.Models
{
    public class FilterSearchRequest : SearchRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Contains { get; set; }
    }
}
