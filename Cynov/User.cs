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
        private string _username;
        private string _email;
        

        public int Id
        {
            get;
            set;
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (!Validator.IsBetween(value, 8, 16))
                    throw new DataException("Incorrect username's length");
                _username = value;
            }

        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!Validator.IsValidEmail(value))
                    throw new DataException("Incorrect email form");
                _email = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!Validator.IsValidPass(value, 6))
                    throw new DataException("Incorrect pass form");
                _password = value;
            }
        }

        public bool IsAdmin
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public DateTime LastUpdateTime
        {
            get;
            set;
        }

        public List<Showtime> Showtimes
        {
            get;
            set;
        }
        public List<Order> Orders
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
            IsActive = true;
            Showtimes = new List<Showtime>();
            Orders = new List<Order>();
            LastUpdateTime = DateTime.Now;
        }
    }
}
