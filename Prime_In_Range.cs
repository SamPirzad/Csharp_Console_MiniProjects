/*
This app inputs two numbers and outputs all the prime numbrs existing in between

Example Input : 
4
15
Example Output :
5
7
11
13
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            bool IsPrime;

            for (int i = start; i <= end; i++)
            {

                IsPrime = true;
                if (i <= 1) 
                    IsPrime = false;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) 
                        IsPrime = false;
                }
                
                if (IsPrime==true)
                    Console.WriteLine(i);
            }
        }
    }
}  

