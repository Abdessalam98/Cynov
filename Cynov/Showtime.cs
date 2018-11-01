using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class Showtime
    {
        public int Id { get; set; }

        public Auditorium Auditorium { get; set; }

        public DateTime Start
        {
            get; set;
        }

        public DateTime Finish
        {
            get;
            set;
        }

        public bool ThreeDimensional
        {
            get;
            set;
        }

        public bool OriginalVersion
        {
            get;
            set;
        }

        public List<User> Users
        {
            get;
            set;
        }

        public Film Film
        {
            get;
            set;
        }

    }
}
