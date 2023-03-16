/*
This app inputs a starting and ending point on a two direction border and caculated how you should move and in which direction
Example inpput:
-1
4
Example output:
RRRRR
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Movement
{
    class Program
    {
        static void Main(string[] args)
        {

            int Start = int.Parse(Console.ReadLine());
            int End = int.Parse(Console.ReadLine());

            int Distance = End - Start;

            if (Distance > 0)
            { 
                for (int i = Distance ; i > 0 ; i--)
                    Console.Write("R");
            }
            else if (Distance < 0)
            {
                for (int i = Distance; i < 0; i++)
                    Console.Write("L");
            }
            else
                Console.WriteLine("Saal Noo Mobarak!");

            
        }
    }
}  

