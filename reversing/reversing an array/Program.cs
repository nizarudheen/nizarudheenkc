using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversing_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str, Revstr = "" ;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();

            for (int i = Str.Length - 1; i >= 0; i--)
            {

                Revstr = Revstr + Str[i];
            }

            Console.WriteLine("Reverse  String  Is  {0}", Revstr);
            Console.ReadKey();


        }
    }
}
