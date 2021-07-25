using Mail.Data.Models;
using Mail.Organize.Interfaces;
using Mail.Organize.Mappers;
using System;
using System.Linq;

namespace Mail.Organize.Implementation
{
    public class OrganizeMailDirectory : IOrganizeMailDirectory
    {
        private MapperDirectory mapper;

        public OrganizeMailDirectory()
        {
            mapper = new MapperDirectory();
        }

        public void MoveMailDirectory(Data.Models.Mail mail, BaseDirectory origin, BaseDirectory destiny)
        {
            var originFormated = mapper.directoryDictionary.First(x => x.Key == origin.Type).Value;
            var destinyFormatted = mapper.directoryDictionary.First(x => x.Key == destiny.Type).Value;

            if (originFormated.GetType() == typeof(BaseDirectory))
            {
                if (destiny.GetType() == typeof(BaseDirectory))
                    MoveBetweenBase(mail, destinyFormatted);
                else
                    MoveBaseToCustom(mail, (CustomDirectory)destinyFormatted);
            }
            else
            {
                if (destiny.GetType() == typeof(CustomDirectory))
                    MoveBetweenCustom(mail, (CustomDirectory)destinyFormatted);
                else
                    MoveCustomToBase(mail, destinyFormatted);
            }
        }

        private void MoveBaseToCustom(Data.Models.Mail Mail, CustomDirectory destinyDir)
        {
            Mail.Directory = null;
            Mail.CustomDirectory = destinyDir;
        }

        private void MoveCustomToBase(Data.Models.Mail Mail, BaseDirectory destinyDir)
        {
            Mail.CustomDirectory = null;
            Mail.Directory = destinyDir;
        }

        private void MoveBetweenBase(Data.Models.Mail Mail, BaseDirectory destinyDir)
        {
            Mail.Directory = destinyDir;
        }

        private void MoveBetweenCustom(Data.Models.Mail Mail, CustomDirectory destinyDir)
        {
            Mail.CustomDirectory = destinyDir;
        }
    }
}
