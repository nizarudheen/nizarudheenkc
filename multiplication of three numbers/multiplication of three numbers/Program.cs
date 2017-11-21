using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int frst, scnd,thrd;

            Console.WriteLine("Input the first number to multiply:");
            frst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply:");
            scnd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply:");
            thrd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("expected output:");
            Console.WriteLine("{0}*{1}*{2}={3}" , frst, scnd, thrd, frst*scnd*thrd);
            Console.ReadKey();
        }
    }
}
