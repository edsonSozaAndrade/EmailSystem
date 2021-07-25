using Mail.Data.Enums;
using Mail.Search.Models;
using Mail.Search.SearchTypes;
using System;
using System.Collections.Generic;

namespace MailSystem.Mapper
{
    public class SearchMapper
    {
        public List<KeyValuePair<SearchType, SearchProcessor>> searchDictionary = new List<KeyValuePair<SearchType, SearchProcessor>>();

        public SearchMapper()
        {
            searchDictionary.Add(new KeyValuePair<SearchType, SearchProcessor>(SearchType.Filter, new FilterSearchProcessor()));
            searchDictionary.Add(new KeyValuePair<SearchType, SearchProcessor>(SearchType.Simply, new SimplySearchProcessor()));
        }
    }
}
