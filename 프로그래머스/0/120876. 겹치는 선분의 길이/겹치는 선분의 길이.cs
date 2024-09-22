using System;

public class Solution
{
    public int solution(int[,] lines)
    {
        int length = 201;
        int size = lines.Length / 2;
        int[] arr = new int[length];
        int answer = 0;
        int start, end;
        
        for (int i = 0; i < size; ++i)
        {
            start = lines[i, 0] + 100;
            end = lines[i, 1] + 100;
            for (int j = start; j < end; ++j)
            {
                arr[j]++;
            }
        }
        
        foreach (int count in arr)
        {
            if (count > 1)
            {
                answer++;
            }
        }
        
        return answer;
    }
}