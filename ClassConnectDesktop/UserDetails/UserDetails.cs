using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConnectDesktop
{
    // Define a class to represent user details
    public static class UserDetails
    {
        // Properties to store user information
        public static string Username  = "nsatpute";
        public static string Password = "1986";
        public static string Email = "satputenandkumar0@gmail.com";

        public static bool AuthenticateUser(string username, string password)
        {
            // Check if the provided username and password match the stored credentials
            if (username == UserDetails.Username && password == UserDetails.Password)
            {
                // Authentication successful
                return true;
            }
            else
            {
                // Authentication failed
                return false;
            }
        }
    }
}
