using System;

public class Solution
{
    public int solution(int balls, int share)
    {
        long answer = 1;
        int size = balls > 2 * share ? share : balls - share;
        
        for (int i = 0; i < size; ++i)
        {
            answer *= (balls - i); 
            answer /= (i + 1);
        }
        
        return (int)answer;
    }
}