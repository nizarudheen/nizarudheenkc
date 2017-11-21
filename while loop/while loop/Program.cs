using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
         public static int x = 0,i;
        static void Main(string[] args)
         
             {
 
Console.WriteLine("enter the number:");
i = Convert.ToInt16(Console.ReadLine());            
                 
             
             while (x <= i)
             {
                 Console.WriteLine(" {0}", x);
                 x++;
                
             }
             Console.ReadKey();
         }
    }
}
