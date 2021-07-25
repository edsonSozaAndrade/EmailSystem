using System;
using System.Collections.Generic;
using System.Text;

namespace Mail.Search.Interfaces
{
    public interface ICommandInterpreter
    {
        public List<Data.Models.Mail> ParseRequest(string request);
    }
}
