using Mail.Search.Interfaces;
using Mail.Search.Models;
using System;
using System.Collections.Generic;

namespace Mail.Search.SearchTypes
{
    public class FilterSearchProcessor : SearchProcessor
    {
        public override List<Data.Models.Mail> Search(SearchRequest request)
        {
            Console.WriteLine("Performing search by object");
            return new List<Data.Models.Mail>();
        }
    }
}
