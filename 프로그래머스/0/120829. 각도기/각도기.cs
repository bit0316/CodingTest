using System;

public class Solution
{
    public int solution(int angle)
    {
        int answer = angle / 90 * 2;
        
        if (angle % 90 != 0)
        {
            answer++;
        }
        
        return answer;
    }
}