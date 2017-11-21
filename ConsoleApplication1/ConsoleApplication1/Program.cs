using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static int i,k,j,l;
        public static string[] head = { "Name", "Address", "MobNo", "M1", "M2", "Total" };
        
        public static string[] name =new string [100];
        public static string[] address =new string [100];
        public static int[]mobno=new int[100];
        public static int[]m1= new int[100];
        public static int[]m2= new int[100];
        public static int[]total= new int[100];

        static void Main(string[] args)
        {
            
                Console.WriteLine("enter the number of students");
                i = Convert.ToInt32(Console.ReadLine());
                read();
                report();
                Console.ReadKey();
        }
        public static void read()
    {
            for(k=1;k<=i;k++)
            {
                 Console.WriteLine("student "+k+" name ");
                name[k] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("student " + k + " address ");
                address[k] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("student " + k + " mobile no ");
                mobno[k] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("student " + k + " mark 1 ");
                m1[k] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("student " + k + " mark 2 ");
                m2[k] = Convert.ToInt32(Console.ReadLine());
                total[k] = m1[k] + m2[k];

            }

    }
        public static void report()
        {
            Console.WriteLine("           Student Report                 ");
            Console.WriteLine("---------------------------------------------------------------------");
            for (l = 0; l <= 5; l++)
            {

                Console.Write(head[l]);
                Console.Write("        ");

            }
            Console.WriteLine("\n");
            
       for ( j = 1; j<=i; j++)
            {
                Console.Write(name[j]);
                Console.Write("        ");
                Console.Write(address[j]);
                Console.Write("        ");
                Console.Write(mobno[j]);
                Console.Write("        ");
                Console.Write(m1[j]);
                Console.Write("        ");
                Console.Write(m2[j]);
                Console.Write("        ");
                Console.Write(total[j]);
                Console.WriteLine("\n");

            }




        }


            
            
            
            
          

            }
            
    }

