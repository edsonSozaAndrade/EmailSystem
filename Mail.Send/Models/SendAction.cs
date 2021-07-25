using System;
using System.Collections.Generic;
using System.Text;

namespace Mail.Actions.Models
{
    public class SendAction : MailAction
    {
        public SendAction(List<Data.Models.Mail> listMails) : base(listMails)
        {

        }
    }
}
