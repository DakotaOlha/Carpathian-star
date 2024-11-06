using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpathian_star
{
    internal class UserData
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public long Balance { get; set; }

        public UserData() { }

        public UserData(string login, string password)
        {
            Login = login;
            Password = password;
        }
        ~UserData() { }
    }
}
