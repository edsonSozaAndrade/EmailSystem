using Mail.Actions.Interface;
using Mail.Actions.Models;
using System;
using System.Collections.Generic;

namespace Mail.Actions.Observers
{
    public class ReceiveMailObserver : IMailActionListener
    {
        public void NewMailAction(MailAction newAction)
        {
            newAction._listMails = new List<Data.Models.Mail>();
            Console.WriteLine("Receiving Messages...");
            //Fill data to MailAction
        }
    }
}
