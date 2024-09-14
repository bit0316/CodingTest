using System;

public class Solution
{
    public int solution(int order)
    {
        int answer = 0;
        int num;
        
        while (order > 0)
        {
            num = order % 10;
            if (num > 0 && num % 3 == 0)
            {
                answer++;
            }
            order /= 10;
        }
        
        return answer;
    }
}