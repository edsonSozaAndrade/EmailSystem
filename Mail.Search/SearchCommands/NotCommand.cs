using Mail.Search.Models;
using System.Collections.Generic;

namespace Mail.Search.SearchCommands
{
    public class NotCommand : Models.SearchCommands
    {
        private CommandReceptor _receptor;

        public NotCommand(CommandReceptor receptor) : base (receptor)
        {
            _receptor = receptor;
        }

        public override List<Data.Models.Mail> Execute()
        {
            return _receptor.Not();
        }
    }
}
