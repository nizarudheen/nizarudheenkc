using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematical_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;

            Console.WriteLine("Input the first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            y = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("expected output:");
            Console.WriteLine("{0}+{1}={2}",x,y,x+y);
            Console.WriteLine("{0}-{1}={2}", x, y, x -y);
            Console.WriteLine("{0}*{1}={2}", x, y, x * y);
            Console.WriteLine("{0}/{1}={2}", x, y, x / y);
            Console.WriteLine("{0}%{1}={2}", x, y, x % y);
            Console.ReadKey();
        }
    }
}
