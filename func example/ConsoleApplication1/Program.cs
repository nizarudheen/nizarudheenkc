using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int nmbr = 0;
        static void Main(string[] args)
        {
            read();
            display();

            Console.WriteLine("end");
            Console.ReadKey();
        }
        public static void read()
        {
            Console.WriteLine("enter number");
            nmbr = Convert.ToInt32(Console.ReadLine());
        }

        public static void display()
        {
            Console.WriteLine(nmbr);
        }
    }
}