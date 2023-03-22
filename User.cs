using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string number { get; set; }

        public User(string first_name, string last_name, string email, string password, string number)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
            this.number = number;
        }
    }
}