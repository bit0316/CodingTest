using System;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int size = sizes.GetLength(0);
        int answer = 0;
        int width = 0;
        int height = 0;
        int max, min;
        
        for (int i = 0; i < size; ++i)
        {
            max = Math.Max(sizes[i, 0], sizes[i, 1]);
            min = Math.Min(sizes[i, 0], sizes[i, 1]);
            width = Math.Max(width, max);
            height = Math.Max(height, min);
        }
        answer = width * height;
        
        return answer;
    }
}