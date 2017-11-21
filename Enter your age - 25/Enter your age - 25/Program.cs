using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_your_age___25
{
    class Program
    {
        public static decimal x;
        static void Main(string[] args)
        {
        read();
        }
        public static void read()
        {
            

            Console.WriteLine("enter your age:");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("you look older than    {0}", x);
            Console.ReadKey();

        }
    }
}
