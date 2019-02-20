using EulerMath;
using System;
public class Problem1{
    int Target {get; set;}
    public Problem1(int target)
    {
        Target = target -1;
    }

    public int Resolve(){
        int Threes = CountofTerms(3);
        int Fives = CountofTerms(5);
        int Fifteens = CountofTerms(15);

        int answer = SumSequenceMultipliers(3, Threes);
        answer += SumSequenceMultipliers(5, Fives);
        answer -= SumSequenceMultipliers(15, Fifteens);
        return answer;
    }

    private int CountofTerms(int number){
        decimal divided = (decimal) Target / number;
        return (int) Math.Floor(divided);
    }

    private int SumSequenceMultipliers(int multiplier, int to){
        int answer = (int) Algorithms.SumSequence(to);
        answer *= multiplier;
        return answer;
    }
}