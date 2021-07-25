using Mail.Data.Models;
using Mail.Organize.Implementation;
using Mail.Organize.Interfaces;
using MailSystem.Interfaces;

namespace MailSystem.Implementation
{
    public class OrganizeManager : IOrganizeManager
    {
        private readonly IOrganizeCustomDirectory _customManager;
        private readonly IOrganizeMailDirectory _mailOrganizer;

        public OrganizeManager()
        {
            _customManager = new OrganizeCustomDirectory();
            _mailOrganizer = new OrganizeMailDirectory();
        }

        #region Custom Directory

        public void CreateCustomDirectory(CustomDirectory newDirectory)
        {
            _customManager.CreateCustomDirectory(newDirectory);
        }

        public void DeleteCustomDirectory(CustomDirectory newDirectory)
        {
            _customManager.DeleteCustomDirectory(newDirectory);
        }

        public CustomDirectory GetCustomDirectory(string directoryName)
        {
            return _customManager.GetCustomDirectory(directoryName);
        }        

        public void UpdateCustomDirectory(CustomDirectory newDirectory)
        {
            _customManager.UpdateCustomDirectory(newDirectory);
        }
        #endregion
        #region Move Directory
        public void MoveDirectory(CustomDirectory origin, CustomDirectory destiny)
        {
            _customManager.MoveDirectory(origin, destiny);
        }

        public void MoveMailDirectory(Mail.Data.Models.Mail Mail, BaseDirectory origin, BaseDirectory destiny)
        {
            _mailOrganizer.MoveMailDirectory(Mail, origin, destiny);
        }
        #endregion
    }
}
