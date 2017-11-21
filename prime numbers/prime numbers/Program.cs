using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
           
            Console.WriteLine("enter the limit number ");
            int y = Convert.ToInt32(Console.ReadLine());


            for (i = 2; i <= y; i++)
            {   
                for (j = i - 1; j >= 2; j--)
                {
                    if (i % j != 0)
                    {
                        if (j == 2)
                        {
                            Console.WriteLine(i);
                        }


                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();   
                }
           
            }
            
        }
    

