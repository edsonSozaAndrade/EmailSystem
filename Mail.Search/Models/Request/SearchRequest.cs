using Mail.Data.Enums;
using System;

namespace Mail.Search.Models
{
    public class SearchRequest
    {
        public SearchType SearchType { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string? From { get; set; }
        public string? To { get; set; }
        public string? Subject { get; set; }
        public string? Contains { get; set; }

        public string? TextSearch { get; set; }
    }
}
