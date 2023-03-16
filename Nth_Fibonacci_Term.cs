
/* 
This app inputs the N th term of the Fibonacci sequence and shows the first to N th term in differant lines
Example input : 
4
Example output :
1
1
2
3
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Fibonacci_Term
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int first = 1;
            int second = 1;


            if (n == 0)
                Console.WriteLine("0");
            else if (n == 1)
                Console.WriteLine(first);
            else if (n == 2)
                Console.WriteLine(first + "\n" +second); 
            else
            {
                Console.WriteLine(first + "\n" + second); 
                for (int i = n-2; i > 0; i--)
                {
                    int third = first + second;

                    Console.WriteLine(first + second);

                    first = second;
                    second = third;
                }
            }
            
        }
    }
}  

