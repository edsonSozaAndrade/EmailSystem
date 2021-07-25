using Mail.Actions.Interface;
using System.Collections.Generic;

namespace Mail.Actions.Models
{
    public abstract class MailAction
    {
        public List<Data.Models.Mail> _listMails { get; set; }
        private List<IMailActionListener> _events = new List<IMailActionListener>();

        public MailAction(List<Data.Models.Mail> listMails)
        {
            _listMails = listMails;
        }        

        public void Attach(IMailActionListener mailEvent)
        {
            _events.Add(mailEvent);
        }

        public void Detach(IMailActionListener mailEvent)
        {
            _events.Remove(mailEvent);
        }

        public void NotifyActionEvent()
        {
            foreach (IMailActionListener mailEvent in _events)
            {
                mailEvent.NewMailAction(this);
            }
        }
    }
}
