using System.Collections.Generic;

namespace Mail.Search.Models
{
    public abstract class SearchCommands
    {
        protected CommandReceptor _receiver;

        public SearchCommands(CommandReceptor receiver)
        {
            _receiver = receiver;
        }

        public abstract List<Data.Models.Mail> Execute();
    }
}
