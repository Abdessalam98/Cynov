using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class Order
    {

        public int Id { get; set; }
        public DateTime PrintDate { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public string OrderId { get; set; }
        public User User { get; set; }

        public Order()
        {
            PrintDate = DateTime.Now;
            OrderId = Guid.NewGuid().ToString("N").Substring(0, 10);
            Company = "Cynov";
        }
    }

}
