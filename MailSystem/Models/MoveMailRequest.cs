using Mail.Data.Models;

namespace MailSystem.Models
{
    public class MoveMailRequest
    {
        public Mail.Data.Models.Mail mail { get; set; }
        public CustomDirectory origin { get; set; }
        public CustomDirectory destiny { get; set; }
    }
}
