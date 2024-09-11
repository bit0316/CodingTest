using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 1;
        
        while (n >= 1)
        {
            answer++;
            n /= answer;
        }
        answer--;
        
        return answer;
    }
}