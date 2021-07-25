using Mail.Data.Models;

namespace Mail.Organize.Interfaces
{
    public interface IOrganizeMailDirectory
    {
        void MoveMailDirectory(Mail.Data.Models.Mail Mail, BaseDirectory origin, BaseDirectory destiny);
    }
}
