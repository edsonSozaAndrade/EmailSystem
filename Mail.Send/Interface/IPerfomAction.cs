using System.Collections.Generic;

namespace Mail.Actions.Interface
{
    public interface IPerfomAction
    {
       void Send(List<Data.Models.Mail> mails);
        List<Data.Models.Mail> Receive();
    }
}
