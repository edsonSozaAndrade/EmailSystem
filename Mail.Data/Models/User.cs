using System;

namespace Mail.Data.Models
{
    public class User
    {
        public Guid IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
