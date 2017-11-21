using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j;

            Console.WriteLine("enter the number upto  continue:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n; i >= 0; i--)
            {
                Console.Write("\n");
                Console.Write("\n");
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
            }




                Console.ReadKey();
                



        }
    }

}