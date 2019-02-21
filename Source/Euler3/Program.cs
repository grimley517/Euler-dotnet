using System;
using EulerMath;

namespace Euler3
{
    class Program
    {
        static void Main(string[] args)
        {
            var prob = long.Parse(args[0]);
            Console.WriteLine(Algorithms.HighestPrimeFactor(prob));
        }
    }
}
