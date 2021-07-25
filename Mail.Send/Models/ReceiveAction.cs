using System.Collections.Generic;

namespace Mail.Actions.Models
{
    public class ReceiveAction : MailAction
    {
        public ReceiveAction(List<Data.Models.Mail> listMails) :base(listMails)
        {
            
        }
    }
}
