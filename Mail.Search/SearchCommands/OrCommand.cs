using Mail.Search.Models;
using System.Collections.Generic;

namespace Mail.Search.SearchCommands
{
    public class OrCommand : Models.SearchCommands
    {
        private CommandReceptor _receptor;

        public OrCommand(CommandReceptor receptor) : base(receptor)
        {
            _receptor = receptor;
        }

        public override List<Data.Models.Mail> Execute()
        {
            return _receptor.Or();
        }
    }
}
