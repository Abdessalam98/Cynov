using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class CynovContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Film> Films { get; set; }

        public DbSet<Showtime> Showtimes { get; set; }

        public DbSet <Auditorium> Auditoriums { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
