using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_angles
{
    class Program
    {    
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if (A == 0 || B == 0 || C == 0)
                Console.WriteLine("No");
            else if (A >= 180 || B >= 180 || C >= 180)
                Console.WriteLine("No");
            else if ((A + B + C) == 180)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}
