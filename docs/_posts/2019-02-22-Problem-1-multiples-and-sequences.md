---
layout: post
title: "Problem 1 - Multiples and Sequences" 
time: 2019-02-22 09:00:00 +0000
categories: euler problem1
---

## Introduction

The task is to sum the multiples of 3 and 5 under a number. 

A test case is given, the sum of multiples of these primes is 23.

## Extending the test

The given test of numbers to 10 missed an important case.  we should extend the number to 30 to include the case where a number is a multiple of 3 and 5.

Looking at the numbers up to 30;

- multiples of 3 = [3, 6, 9, 12, 15, 18, 21, 24, 27]
- multiples of 5 = [5, 10, 15, 20, 25]

30 is a good test case as it demonstrates two principles.  Firstly the inclusion of 15 twice, and secondly the non inclusion of 30 as its under the target of both. 

So we need to remove the multiples of 15 from the total;

- multiples of 15 = \[15]

```csharp
    [TestMethod]
    public void TestToThirty()
    {
        // threes: 3,6,9,12,15, 18, 21, 24, 27 => 135
        // fives: 5, 10, 15, 20, 25,=> 75
        // Subtotal => 210
        // Remove 15 counted twice => 195
        int expected = 195; 
        var prob = new Problem1(30);
        int actual = (int) prob.Resolve();
        Assert.AreEqual(expected, actual);
    }
```

## Calculating the sequences

If we focus on the multiples of 5 for a moment; we can see that these might be rewritten;

$$ \begin{bmatrix} 1 \times 5, & 2 \times 5, & 3 \times 5, & 4 \times 5, & 5 \times 5 \end{bmatrix} $$

or better yet;

$$ \displaystyle\sum_{i=1}^{n} 5i $$

where 

$$ n = \left\lfloor target \div 5 \right\rfloor $$

For our target sequence this translates to;

```csharp
int Fives = CountofTerms(5);

private int CountofTerms(int number){
    decimal divided = (decimal) Target / number;
    return (int) Math.Floor(divided);
}
```

## Sum of a Sequence

