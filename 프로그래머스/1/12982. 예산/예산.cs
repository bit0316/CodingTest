using System;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        int size = d.Length;
        int answer = 0;
        int total = 0;
        
        Array.Sort(d);
        for (int i = 0; i < size; ++i)
        {
            total += d[i];
            if (total > budget)
            {
                break;
            }
            answer++;
        }
        
        return answer;
    }
}