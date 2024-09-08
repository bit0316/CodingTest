using System;

public class Solution
{
    public int[] solution(int[] emergency)
    {
        int size = emergency.Length;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (emergency[j] <= emergency[i])
                {
                    answer[j]++;
                }
            }
        }
        
        return answer;
    }
}