using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
       public static int i,j,x,z,y;
        static void Main(string[] args)
        {
          
            Console.WriteLine("press 1 for single number");
            Console.WriteLine("press 2 for multiple number");
            i=Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                //read();

            }
            else
            {
                read2();
            }
            }
        //public static void read()
        //{

        //    Console.WriteLine("enter the number");
        //    x = Convert.ToInt32(Console.ReadLine());

        //    z = 1;

        //    for (j = 1; j <= x; j++)
        //    {
        //        z = z * j;
        //        Console.Write(j + "*");
        //    }
        //    Console.Write("=" + z);


        //    Console.ReadLine();
        //}
        public static void read2()
    {
        Console.WriteLine("enter the number");
        x = Convert.ToInt32(Console.ReadLine());

      
        for (y = x; y >= 1; y--)
        {
            z = 1;
            for (j = 1; j <= y; j++)
            {
                z = z * j;
                Console.Write(j );
                if(j!=y)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("=" + z);
          
        }
        Console.ReadKey();
    }
    
        }
    }

