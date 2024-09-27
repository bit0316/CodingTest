using System;

public class Solution
{
    public long solution(int a, int b)
    {
        long answer = 0;
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        
        for (int i = start; i <= end; ++i)
        {
            answer += i;
        }
        
        return answer;
    }
}