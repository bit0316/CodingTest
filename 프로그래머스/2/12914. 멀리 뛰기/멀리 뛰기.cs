using System;
public class Solution
{
    const int DIV_SIZE = 1234567;
    
    public long solution(int n)
    {
        long before = 0;
        long answer = 1;

        for (int i = 1; i <= n; ++i)
        {
            (before, answer) = (answer, (before + answer) % DIV_SIZE);
        }
        
        return answer;
    }
}