using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindVector
{
    internal class Program
    {
        static int FindVector(int Fx1, int Fy1, int Fx2, int Fy2)
        {
            var Fx = Fx2 - Fx1;
            var Fy = Fy2 - Fy1;
            return (int)FindHypotenuse(Fx, Fy);
        }
        
        static int FindHypotenuse(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindVector(2, 3, 7, -9));
            Console.ReadLine();
        }


    }
}
