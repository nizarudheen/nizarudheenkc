using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_the_largest_and_lowest
{
    class Program
    {
       public static int  x, y, z;
        static void Main(string[] args)
        {
            read();
            display();


            Console.ReadKey();
        }



             public static void read()
            
 {
            Console.WriteLine("Input the first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            z = Convert.ToInt32(Console.ReadLine());
 }
         public static void display()
         {
            {

                if (x < y)
                {
                    if (y < z)
                        Console.WriteLine("the largest number is  {0}", z);
                    else
                        Console.WriteLine("the largest number is  {0}", y);
                }
                else
                    Console.WriteLine("the largest number is  {0}", x);
            }
            {
                if (x > y)
                {
                    if (y > z)
                        Console.WriteLine("the lowest number is  {0}", z);
                    else
                        Console.WriteLine("the lowest number is  {0}", y);
                }
                else
                    Console.WriteLine("the lowest number is  {0}", x);
            
            
            }
         }
        }
        
}
           



        

