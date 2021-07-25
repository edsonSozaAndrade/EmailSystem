using System;
using System.Collections.Generic;

namespace Mail.Search.Models
{
    public class CommandReceptor
    {
        private string _subject1, _subject2;
        public CommandReceptor(string subject1, string subject2)
        {
            _subject1 = subject1;
            _subject2 = subject2;
        }
        public List<Data.Models.Mail> And()
        {
            Console.WriteLine(string.Format("{0} AND {1}", _subject1, _subject2));
            return new List<Data.Models.Mail>();
        }
        public List<Data.Models.Mail> Or()
        {
            Console.WriteLine(string.Format("{0} OR {1}", _subject1, _subject2));
            return new List<Data.Models.Mail>();
        }
        public List<Data.Models.Mail> Not()
        {
            Console.WriteLine(string.Format("NOT {0}", _subject1));
            return new List<Data.Models.Mail>();
        }
    }
}
