using Mail.Data.Models;
using Mail.Organize.Interfaces;

namespace MailSystem.Interfaces
{
    public interface IOrganizeManager
    {
        void CreateCustomDirectory(CustomDirectory newDirectory);
        CustomDirectory GetCustomDirectory(string directoryName);
        void UpdateCustomDirectory(CustomDirectory newDirectory);
        void DeleteCustomDirectory(CustomDirectory newDirectory);
        void MoveDirectory(CustomDirectory origin, CustomDirectory destiny);

        void MoveMailDirectory(Mail.Data.Models.Mail Mail, BaseDirectory origin, BaseDirectory destiny);
    }
}
