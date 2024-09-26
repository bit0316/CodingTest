using System;

public class Solution
{
    public long solution(long n)
    {
        double sqrt = Math.Sqrt(n);
        long answer = -1;
        
        if (sqrt - (long)sqrt == 0)
        {
            answer = (long)Math.Pow(sqrt + 1, 2);
        }
        
        return answer;
    }
}