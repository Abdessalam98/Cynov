using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var m = new Main();
                m.Start();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("Program stopped.");
            }
        }
    }
}