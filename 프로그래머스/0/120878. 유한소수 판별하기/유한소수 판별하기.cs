using System;

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 2;
        
        while (b % 2 == 0)
        {
            b /= 2;
        }
        while (b % 5 == 0)
        {
            b /= 5;
        }
        if (a % b == 0)
        {
            answer = 1;
        }
        
        return answer;
    }
}