using System.Collections.Generic;

namespace Mail.Data.Models
{
    public class MailAccount
    {
        public User User { get; set; }
        public List<Mail> Mails { get; set; }
        public List<BaseDirectory> Principal { get; set; }
        public List<CustomDirectory> CustomDirectory { get; set; }
    }
}
