using System.Collections.Generic;

namespace Mail.Data.Models
{
    public class Header
    {
        public string Subject { get; set; }
        public List<string> Copy { get; set; }
        public string From { get; set; }
        public List<string> To { get; set; }
    }
}
