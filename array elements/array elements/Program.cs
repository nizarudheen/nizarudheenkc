using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k,l,temp;
            int[]aray=new int[5];
            Console.WriteLine("enter the array elements");
            for (i = 0; i <= 4; i++)
            {
                aray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(j=0;j<=4;j++)
            {
                for (k = j + 1; k <= 4; k++)
                {
                    if(aray[k]<aray[j])
                    {
                        string a = aray[j].ToString();
                        string b = aray[k].ToString();
                        temp=aray[j];
                        aray[j] = aray[k];
                       
                        aray[k] = temp;
                        


                    }
                }
            }
                for (l = 0; l <= 4; l++)
                {
                    Console.WriteLine("   " +aray[l]);
                }
                Console.ReadKey();
            }
            
        


    }
}


