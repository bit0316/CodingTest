using System;

public class Solution
{
    public int solution(int k, int m, int[] score)
    {
        int size = score.Length;
        int answer = 0;
        int min;
        
        Array.Sort(score);
        for (int i = size - 1; i >= m - 1; i -= m)
        {
            min = score[i];
            for (int j = i - 1; j > i - m; --j)
            {
                if (min > score[j])
                {
                    min = score[j];
                }
            }
            answer += min * m;
        }
        
        return answer;
    }
}