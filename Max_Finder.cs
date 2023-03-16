
/*
This app asks the user how may numbers you want to compare and then inputs the numbers 
it outputs the max value

Example input : 
4
6
9
10
3
Example output :
10
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Finder
{
    class Program
    {    
        static void Main(string[] args)
        {
            // Input the count of numbers
            int n = int.Parse(Console.ReadLine());

            // Input n numbers in one line
            string[] input = Console.ReadLine().Split();

            // Find the maximum of the numbers
            int max = int.Parse(input[0]);
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(input[i]);
                if (num > max)
                {
                    max = num;
                }
            }

            // Output the maximum
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
