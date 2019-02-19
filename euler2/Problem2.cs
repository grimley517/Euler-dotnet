using EulerMath;
public class Problem2{

    public int Target {get; set;}

    public Problem2(int target)
    {
        Target = target;
    }

    public int Resolve()
    {
        int answer = 0;
        int n = 0;
        int term = 0;
        while(term < Target){
            term = Algorithms.Fibo(n);
            answer += CheckTerm(term);
            n++;
        }
        return answer;
    }

    private int CheckTerm(int term){
        if (term %2 ==0 && term < Target){
            return term;
        }
        else{
            return 0;
        }
    }
}