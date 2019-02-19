using System;

namespace EulerMath
{
    public static class Algorithms
    {
        public static decimal SumSequence(int number){
            decimal left = number + 1.0m;
            decimal right = number / 2.0m;
            return left * right;
        }

        public static int Fibo (int term){
            if (term == 0){
                return 1;
            }
            else if (term == 1){
                return 2;
            }
            else {
                return Fibo(term-1) + Fibo(term-2);
            }
        }
    }
}
