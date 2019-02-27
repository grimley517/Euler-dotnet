---
layout: post
title: "Problem 2 - Even Fibonacci numbers" 
time: 2019-02-22 09:00:00 +0000
categories: euler problem2
---

## Introduction

The task is to sum the even members of the Fibonacci sequence. 

## Calculating the Fibonacci sequence

The fibonaci sequence is a sequence of numbers which is made of adding the previous two terms.  By defining the first two terms we can use a recursive definition to generate the sequence.

```csharp
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
```

When writing a recursive function two things are needed. Firstly an end state is needed, and secondly the function adjust itself untill it gets to a known state. The _Fibocache_ dictioary achieves the first criteria by establishing two known components.  In order that a third can be calculated.  The second component is needed otherwise it would be impossible to calculate the first term (term-2  when term == 1 being impossible). The second criteria is within the else part of the function.

The _Fibocache_ should build up during the course of the run to prevent values being calculated more than once.  This is valid on the basis that time is more valuable than memory. 

It may be possible to calculate this in a more straight forward manner but the Fibo from term function is likely to be of use later.

## Filtering the Even Terms

```csharp
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
```

The Resolve() method uses a while loop to cycle through the sequence untill the maximaum value is reached.  The checkterm adds the term to the answer only if the term is even (term % 2 == 0).  the percentage sign here means to do a division and check the remainder.  If the Remainder is 0, then it is divisible by 2 therefore even.

## Non recursive Solution

```csharp

    public int Resolve()
    {
        int answer = 2;
        int r1 = 1;
        int r2 = 2;
        int r3 = 0; //has to have a value otherwise the while loop fails
        while(r3 < Target){
            r3 = r1 + r2;
            if (r3 % 2 == 0)
            {
                answer += r3
            }
            r1 = r2;
            r2 = r3
        }
        return answer;
    }
```

The same problem can be solved without recursion, and this may be quicker. The variables _r1_ _r2_ and _r3_ are three registers that cycle through the while loop, with r3 being added to the answer if its even.  Note the answer starts at 2, because the 2 that starts in _r2_ wouldn't get counted otherwise.  

Often code that is more readable is better than code that is code that is obscure. It is humans that will end up maintaing your code, and the above is a little obscure, and tries to do too much in one function.  Breaking down the code into more useful parts is also good practice.  If this were part of a production system, this could be optimised later to something like this if the speed was an issue. I'm thinking that the Fibo() function will come in handy later.

 (My full solution is available on github.)[https://github.com/grimley517/Euler-dotnet/blob/master/Source/Euler2/Problem2.cs]      ]