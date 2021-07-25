using Mail.Data.Enums;
using System;

namespace Mail.Data.Models
{
    public class BaseDirectory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DirectoryType Type { get; set; }
    }
}
