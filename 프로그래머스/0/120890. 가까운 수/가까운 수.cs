using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        int answer = int.MaxValue;
        int min = int.MaxValue;
        int diff;
        
        foreach (int num in array)
        {
            diff = Math.Abs(num - n);
            if(min > diff)
            {
                min = diff;
                answer = num;
            }
            else if (min == diff)
            {
                answer = num < answer ? num : answer;
            }
        }
        
        return answer;
    }
}