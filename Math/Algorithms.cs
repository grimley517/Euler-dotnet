using System;
using System.Collections.Generic;

namespace EulerMath
{
    public static class Algorithms
    {


        public static decimal SumSequence(int number){
            decimal pairTotal = number + 1.0m;
            decimal pairCount = number / 2.0m;
            return pairTotal * pairCount;
        }
        
        public static Dictionary<int, int> Fibocache {get; set;} = new Dictionary<int, int>{
            {0,1},
            {1,2}
        };

        public static int Fibo (int term){
            if (Fibocache.ContainsKey(term)){
                return(Fibocache[term]);
            }            
            else {
                int result = Fibo(term-1) + Fibo(term-2);
                Fibocache.Add (term, result);
                return result;
            }
        }

        public static long HighestPrimeFactor(long number){
            long  answer = 2;
            long limit = (int) Math.Ceiling(Math.Sqrt(number)) +1;
            
            while (answer < limit){
                if( Divisible(number, answer)){
                    long newNumber =  number / answer;
                    if (IsPrime(newNumber)){
                       return newNumber; 
                    }
                    else{
                        return HighestPrimeFactor(newNumber);
                    }                    
                }
                answer++;
            }
            return 1;
        }


        private static bool Divisible(long number, long answer){
            return number % answer == 0;
        }

        private static bool IsPrime(long answer){
            return HighestPrimeFactor(answer) == 1;
        }
    }
}
