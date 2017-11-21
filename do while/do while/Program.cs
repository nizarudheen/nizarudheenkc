using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        public static string x;
        public static string y = "n";

        static void Main(string[] args)
        {
            
                read();
                write();
            }





            public static void read()
            {
                Console.WriteLine("enter the first letter of the name");
                x=Convert.ToString(  Console.ReadLine());
 

            }
            public static void write()
            {
                //do
                //{
                //    Console.WriteLine(" nizarudheen k c");
                //} while (String.Compare(n,x)); 

                if (x == "n")
                {
                    Console.WriteLine("nizarudheen k c");
                }
                Console.ReadKey();

            }

      
        }
    }

