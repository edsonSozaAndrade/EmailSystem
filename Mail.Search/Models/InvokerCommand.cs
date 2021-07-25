using System.Collections.Generic;

namespace Mail.Search.Models
{
    public class InvokerCommand
    {
        private SearchCommands _command;
        public void SetCommand(SearchCommands command)
        {
            _command = command;
        }
        public List<Data.Models.Mail> Execute()
        {
            return _command.Execute();
        }
    }
}
