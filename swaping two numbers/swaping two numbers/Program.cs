using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swaping_two_numbers
{
    class Program
    {
        public static int x, y;
        static void Main(string[] args)
        {



            Console.WriteLine("enter the number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number");
            y = Convert.ToInt32(Console.ReadLine());
            write();
            Console.ReadKey();
        }

        public static void write()
        {
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("x="+x+"   y"+y);
        }

    }


}
        
    


