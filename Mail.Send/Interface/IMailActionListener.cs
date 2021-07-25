using Mail.Actions.Models;

namespace Mail.Actions.Interface
{
    public interface IMailActionListener
    {
        public void NewMailAction(MailAction newAction);
    }
}
