using Mail.Actions.Interface;
using Mail.Actions.Models;
using Mail.Actions.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mail.Actions.Implementation
{
    public class PerfomAction : IPerfomAction
    {
        public List<Data.Models.Mail> Receive()
        {
            ReceiveAction receive = new ReceiveAction(null);
            receive.Attach(new ReceiveMailObserver());
            receive.NotifyActionEvent();

            return receive._listMails;
        }

        public void Send(List<Data.Models.Mail> mails)
        {
            SendAction send = new SendAction(mails);
            send.Attach(new SendMailObserver());
            send.NotifyActionEvent();
        }
    }
}
