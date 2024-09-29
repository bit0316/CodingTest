using System;

public class Solution
{
    public int solution(int[] number)
    {
        int size = number.Length;
        int answer = 0;
        int total = 0;
        
        for (int i = 0; i < size - 2; ++i)
        {
            total = number[i];
            for (int j = i + 1; j < size - 1; ++j)
            {
                total = number[i] + number[j];
                for (int k = j + 1; k < size; ++k)
                {
                    if (total + number[k] == 0)
                    {
                        answer++;
                    }
                }
            }
        }
        
        return answer;
    }
}