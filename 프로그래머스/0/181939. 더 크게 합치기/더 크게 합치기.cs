using System;

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 0;
        
        answer = Math.Max(int.Parse(a.ToString() + b.ToString()), int.Parse(b.ToString() + a.ToString()));
        
        return answer;
    }
}