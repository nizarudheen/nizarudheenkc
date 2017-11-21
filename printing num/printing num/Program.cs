
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printing_num
{
    class Program
    {
        public static int k, j, l,m;
        public static int[]no = new int[100];
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of digit");
            k = Convert.ToInt32(Console.ReadLine());

            for(l = 0; l <= k; l++)
            {
                Console.WriteLine("enter the numbers");
                no[l] = Convert.ToInt32(Console.ReadLine());
            }


          {

              j = 0;

              for (m = 1; m <= k; m++)
                        {
                            Console.Write("\n");
                            Console.WriteLine("\n");
                            for (int p = 0; p <= m;p++)
                            {
                               
                                    Console.Write(no[j]);
                                    j++;

                            }
                               
                        }

            }
            Console.ReadKey();
        }
    }
}
