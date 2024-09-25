using System;

public class Solution
{
    public int solution(int M, int N)
    {
        int min = Math.Min(M, N) - 1;
        int max = Math.Max(M, N) - 1;
        int answer = min + (min + 1) * max;
        
        return answer;
    }
}