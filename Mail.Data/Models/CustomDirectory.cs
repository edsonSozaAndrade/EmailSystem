using System.Collections.Generic;

namespace Mail.Data.Models
{
    public class CustomDirectory : BaseDirectory
    {
        public CustomDirectory Parent { get; set; }
        public List<Mail> Mails { get; set; }
    }
}
