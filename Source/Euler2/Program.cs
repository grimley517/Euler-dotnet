using System;

namespace euler2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prob = new Problem2(int.Parse(args[0]));
            Console.WriteLine(prob.Resolve());
        }
    }
}
