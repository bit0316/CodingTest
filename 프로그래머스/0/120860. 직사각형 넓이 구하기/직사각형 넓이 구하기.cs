using System;

public class Solution
{
    public int solution(int[,] dots)
    {
        int size = dots.Length / 2;
        int minX = int.MaxValue;
        int maxX = int.MinValue;
        int minY = int.MaxValue;
        int maxY = int.MinValue;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            minX = Math.Min(minX, dots[i, 0]);
            maxX = Math.Max(maxX, dots[i, 0]);
            minY = Math.Min(minY, dots[i, 1]);
            maxY = Math.Max(maxY, dots[i, 1]);
        }
        answer = (maxX - minX) * (maxY - minY);
        
        return answer;
    }
}