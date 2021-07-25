using Mail.Search.Models;
using MailSystem.Interfaces;
using MailSystem.Mapper;
using System.Linq;

namespace MailSystem.Implementation
{
    public class SearchManager : ISearchManager
    {
        private SearchMapper searchmapper;
        public SearchManager()
        {
            searchmapper = new SearchMapper();
        }

        public SearchProcessor GenerateProcessor(SearchRequest request)
        {
            return searchmapper.searchDictionary.First(x => x.Key == request.SearchType).Value;
        }
    }
}
