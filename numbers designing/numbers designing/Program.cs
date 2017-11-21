using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_designing
{
    class Program
    {
        public static int k, j, l, m;
        public static int[] no = new int[100];
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of digit");
            k = Convert.ToInt32(Console.ReadLine());

            for (l = 0; l <= k; l++)
            {
                Console.WriteLine("enter the numbers");
                no[l] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = k; i >= 0; i--)
            {
                Console.Write("\n");
                Console.Write("\n");
                for (int q = 1; q <= i; q++)
                {
                    Console.Write(" ");


                }



                j = 0;

                for (m = 0; m <=3; m++)
                {
                    Console.Write("\n");
                    Console.Write("\n");
                    for (int p = 0; p <= m; p++)
                    {

                        Console.Write(no[j]);
                        j++;

                    }
                }

                Console.ReadKey();
            }

        }
    }
}

