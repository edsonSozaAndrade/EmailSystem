using System.Collections.Generic;

namespace Mail.Search.Models
{
    public abstract class SearchProcessor
    {
        public abstract List<Data.Models.Mail> Search(SearchRequest request);
    }
}
