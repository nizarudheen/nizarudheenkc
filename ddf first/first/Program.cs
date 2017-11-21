using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal scnd1, result1, frst1;
            int frst, scnd, result;
            // Console.WriteLine("add");
            // Console.WriteLine("enter frst nmbr");
            //frst =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter 2nd number");
            // scnd = Convert.ToInt32(Console.ReadLine());
            //result = frst + scnd;
            // Console.WriteLine("result:"+result);
            // Console.WriteLine("sub");
            //Console.WriteLine("enter frst nmbr");
            // frst = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("enter 2nd number");
            // scnd = Convert.ToInt32(Console.ReadLine());
            // result = frst - scnd;
            // Console.WriteLine("result:" + result);
            //  Console.WriteLine("multiplacation");
            //Console.WriteLine("enter the first nmbr");
            //frst = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("entr the second nmbr");
            // scnd1 = Convert.ToDecimal(Console.ReadLine());
            //      result1 = frst * scnd1;
            //      Console.WriteLine("result:" + result1);
            //
            Console.WriteLine("division");
            Console.WriteLine("enter frst nmbr");
            frst1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            scnd1 = Convert.ToDecimal(Console.ReadLine());
            result1 = frst1 / scnd1;
            Console.WriteLine("result:" + result1);

            Console.ReadKey();
        }
    }
}
