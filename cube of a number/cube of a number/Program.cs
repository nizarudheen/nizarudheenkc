using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x,i;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                x = i * i * i;
                Console.WriteLine("number is:" + i + "and cube of" + i + "is  " + x);
            }
            Console.ReadKey();
        }
    }
}
