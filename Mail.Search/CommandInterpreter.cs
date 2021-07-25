using Mail.Search.Interfaces;
using Mail.Search.Models;
using Mail.Search.SearchCommands;
using System.Collections.Generic;

namespace Mail.Search
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private CommandReceptor receptor;

        private AndCommand _andCommand;
        private OrCommand _orCommand;
        private NotCommand _NotCommand;

        public CommandInterpreter()
        {
            
        }

        public List<Data.Models.Mail> ParseRequest(string request)
        {
            var results = new List<Data.Models.Mail>();
            var interpretedCommands = SplitInCommands(request);
            InvokerCommand invoker = new InvokerCommand();
            for (int i = 1; i < interpretedCommands.Count; i++)
            {
                receptor = new CommandReceptor(interpretedCommands[i - 1], interpretedCommands[i + 1]);
                _andCommand = new AndCommand(receptor);
                _orCommand = new OrCommand(receptor);
                _NotCommand = new NotCommand(receptor);
                invoker.SetCommand(_andCommand);
                results = invoker.Execute();
            }
            return results;
        }

        private List<string> SplitInCommands(string request)
        {
            var results = new List<string>();

            results.Add("Name = 'Pedro'");
            results.Add("OR");
            results.Add("Subject = 'Importante'");
            results.Add("AND");
            results.Add("To = 'David'");

            return results;
        }
    }
}
