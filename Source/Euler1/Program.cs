using System;

namespace euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            var prob = new Problem1(int.Parse(args[0]));
            Console.WriteLine(prob.Resolve());
        }
    }
}
