using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            int user;
           decimal frst,scnd;
          //  Console.WriteLine("all mathematical result of two numbers");
          
          //Console.WriteLine("Addition result:      " + (frst + scnd));
          //Console.ReadLine();
          //Console.WriteLine("substration result:   " + (frst - scnd));
          //Console.ReadLine();
          //Console.WriteLine("multiplication result:" + (frst * scnd));
          //Console.ReadLine();
          //Console.WriteLine("division result:      " + (frst / scnd));
          //Console.ReadKey();
            Console.WriteLine("press 1 for add");
            Console.WriteLine("press 2 for sub");
            Console.WriteLine("press 3 for mul");
            Console.WriteLine("press 5 for div");
            Console.WriteLine("enter the first number");
            frst = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("enter the second number");
            scnd = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter any of the options above");
            user = Convert.ToInt32(Console.ReadLine());
            
            if (user == 1)
            {
Console.WriteLine("Addition result:      " + (frst + scnd));
          Console.ReadLine();
            }
            else if(user==2)
            {
                Console.WriteLine("substration result:   " + (frst - scnd));
                Console.ReadLine();

            }
            else if(user==3)
            {
                Console.WriteLine("multiplication result:" + (frst * scnd));
                Console.ReadLine();
            }

            else if (user ==4)
            {
                Console.WriteLine("division result:      " + (frst / scnd));
                Console.ReadKey();
            }
        }
    }
}
