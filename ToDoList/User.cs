using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class User
    {
        private string username { get; set; }
        private string email { get; set; }
        private DateTime dateJoined { get; set; }
        private string password { get; set; }

        public User(string _username, string _email, DateTime _dateJoined, string _password)
        {
            username = _username;
            email = _email;
            dateJoined = _dateJoined;
            password = _password;
        }
    }
}
