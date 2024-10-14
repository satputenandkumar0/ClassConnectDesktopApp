using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConnectDesktop.Class
{
    public class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirebaseAuthSecret { get; set; }
        public string FirebaseUrl { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }
    }
}
