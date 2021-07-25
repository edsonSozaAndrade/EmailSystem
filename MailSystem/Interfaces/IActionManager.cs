using System.Collections.Generic;

namespace MailSystem.Interfaces
{
    public interface IActionManager
    {
        void Send(List<Mail.Data.Models.Mail> mails);
        List<Mail.Data.Models.Mail> Receive();
    }
}
