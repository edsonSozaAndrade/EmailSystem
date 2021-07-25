using Mail.Search.Interfaces;
using Mail.Search.Models;
using System;
using System.Collections.Generic;

namespace Mail.Search.SearchTypes
{
    public class SimplySearchProcessor : SearchProcessor
    {
        private readonly ICommandInterpreter interpreter;

        public SimplySearchProcessor()
        {
            interpreter = new CommandInterpreter();
        }
        public override List<Data.Models.Mail> Search(SearchRequest request)
        {
            return interpreter.ParseRequest(request.TextSearch);
        }
    }
}
