using System;

namespace Mail.Data.Models
{
    public class Mail
    {
        public Header Header { get; set; }
        public Body Body { get; set; }
        public Attachment Attachment { get; set; }
        public CustomDirectory CustomDirectory { get; set; }
        public BaseDirectory Directory { get; set; }
        public DateTime Date { get; set; }
    }
}
