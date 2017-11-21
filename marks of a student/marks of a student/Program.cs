using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marks_of_a_student
{
    class Program
    {
        public static int x;
        public static string y;
        public static string is_integer;
        public static char grade;
        static void Main(string[] args)
        
        {

            write();
            if(!int.TryParse(is_integer, out x))
            {
                read();
                performance();
            }
            else
            {
                Console.WriteLine("please enter mark");
            }

            Console.ReadKey();
        }

        
        public static void write()
        {
            Console.WriteLine("Enter the nane of the student:");
            y=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained:");
            x =Convert.ToInt32(Console.ReadLine());
            
        }
        public static void read()
        {
            if (x <= 100&x >= 90)
            {
                grade ='A';

                Console.WriteLine("Your grade is   : {0}",grade);
            }
            else if (x <= 90 & x >= 80)
            {
                grade = 'B';
                Console.WriteLine("Your grade is   : {0}",grade);
            }
            else if (x <= 80 & x >= 70)
            {
                grade = 'C';
                Console.WriteLine("Your grade is   : {0}",grade);
            }
            else if (x <= 70 & x >= 60)
            {
                grade = 'D';
                Console.WriteLine("Your grade is   : {0}",grade);
            }
            else if (x <= 60 & x >= 50)
            {
                grade = 'E';
                Console.WriteLine("Your grade is   : {0}",grade);
            }
            else if (x < 50 & x >= 45)
            {
                grade = 'P';
                
                Console.WriteLine("Just Pass");
            }
            else if (x < 45)
            {
                grade = 'F';
               
                Console.WriteLine("Failed");
            }
           
        }



        public static void performance()
        {

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("student performance is excellent");
                    break;
                case 'B':
                    Console.WriteLine("student performance is well done");
                    break;
                case 'C':
                    Console.WriteLine("student performance is good");
                    break;
                case 'D':
                    Console.WriteLine("student performance is needs to improve");
                    break;
                case 'E':
                    Console.WriteLine("student performance is needs to improve");
                    break;
                case 'f':
                    Console.WriteLine("student performance is needs to improve a lot");
                    break;
                case 'p':
                    Console.WriteLine("student performance is needs to improve a lot");
                    break;

            }

            Console.ReadKey();


        }


        
        
 
    }
    
    
    
     }
