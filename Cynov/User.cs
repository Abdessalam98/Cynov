using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class User
    {
        private string _password;

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }


        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }

        public bool IsAdmin
        {
            get;
            set;
        }

        public List<Showtime> Showtimes
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Username + " " + Email + " " + Password;
        }

        public User()
        {
            IsAdmin = false;
        }
    }
}
