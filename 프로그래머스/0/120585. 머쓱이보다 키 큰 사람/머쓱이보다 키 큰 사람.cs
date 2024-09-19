using System;

public class Solution
{
    public int solution(int[] array, int height)
    {
        int answer = 0;
        
        foreach (int num in array)
        {
            if (num > height)
            {
                answer++;
            }
        }
        
        return answer;
    }
}