using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_of_four_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,z,a;

            Console.WriteLine("Input the first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number:");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the fourth number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("average of the numbers{0},{1},{2},{3} = {4}", x, y,z,a, (x + y+z+a)/4);
            
            Console.ReadKey();
        }
    }
}
