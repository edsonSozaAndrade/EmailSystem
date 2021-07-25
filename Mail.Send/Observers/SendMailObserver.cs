using Mail.Actions.Interface;
using Mail.Actions.Models;
using System;

namespace Mail.Actions.Observers
{
    public class SendMailObserver : IMailActionListener
    {
        public void NewMailAction(MailAction newAction)
        {
            foreach (var user in newAction._listMails)
            {
                Console.WriteLine(string.Format("Sending Message to {0}...", user.Header.To));
            }
        }
    }
}
