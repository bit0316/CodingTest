using System;

public class Solution
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;
        int count;
        
        for (int i = 1; i <= number; ++i)
        {
            count = 0;
            for (int j = 1; j * j <= i; ++j)
            {
                if (j * j == i)
                {
                    count++;
                }
                else if (i % j == 0)
                {
                    count += 2;
                }
            }
            answer += count > limit ? power : count;
        }
        
        return answer;
    }
}