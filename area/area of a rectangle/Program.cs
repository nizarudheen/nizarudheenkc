using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_a_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, breadth;
            Console.WriteLine("enter the length of rectangle");
            length=Convert.ToInt32 (Console.ReadLine()); 
            Console.WriteLine("enter the breadth of rectangle");
            breadth=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("area = " + length * breadth);
                Console.ReadKey();

        }
    }
}
