using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = IsValid(n) ? 1 : 2;
        
        return answer;
    }
    
    public bool IsValid(int n)
    {
        for (int i = 1; i * i <= n; ++i)
        {
            if (i * i == n)
            {
                return true;
            }
        }
        return false;
    }
}