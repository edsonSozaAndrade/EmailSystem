using Mail.Data.Models;

namespace MailSystem.Models
{
    public class MoveDirectory
    {
        public CustomDirectory origin { get; set; }
        public CustomDirectory destiny { get; set; }
    }
}
