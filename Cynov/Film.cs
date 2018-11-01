using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class Film
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Director { get; set; }

        public string Producer { get; set; }


        public string Gender { get; set; }

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        public FilmType Type {
            get;
            set;
        }

        public List<Showtime> Showtimes
        {
            get;
            set;
        }

        public Film()
        {
            Showtimes = new List<Showtime>();
        }
    }
}
