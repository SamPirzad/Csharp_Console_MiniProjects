/*
Consoder having a lamp
when we type 0 it means the lamp is off and 1 means its turned on
this app inputs the number of seconds we want to chack and then inputs the status of the lamp in each second 
it outputs how many times the lamps status has changed.

Example Input : 
4  // the number of seconds 
0
0
1
0
Example Output : 
2
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lamp
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int Count = int.Parse(Console.ReadLine());
            int First_Mode = int.Parse(Console.ReadLine());

            for (int i = Count - 1; i > 0; i--)
            {
                int Next_Mode = int.Parse(Console.ReadLine());
                if (First_Mode != Next_Mode)
                {
                    count = count + 1;
                    First_Mode = Next_Mode;
                }
            }

            Console.WriteLine(count);
        }
    }
}  

