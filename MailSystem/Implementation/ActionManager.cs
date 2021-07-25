using Mail.Actions.Implementation;
using Mail.Actions.Interface;
using MailSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace MailSystem.Implementation
{
    public class ActionManager : IActionManager
    {
        private readonly IPerfomAction _actioner;

        public ActionManager()
        {
            _actioner = new PerfomAction();
        }

        public List<Mail.Data.Models.Mail> Receive()
        {
            return _actioner.Receive();
        }

        public void Send(List<Mail.Data.Models.Mail> mails)
        {
            _actioner.Send(mails);
        }
    }
}
