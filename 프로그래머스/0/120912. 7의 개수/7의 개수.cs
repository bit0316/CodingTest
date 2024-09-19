using System;

public class Solution
{
    public int solution(int[] array)
    {
        int size = array.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            while (array[i] > 0)
            {
                if (array[i] % 10 == 7)
                {
                    answer++;
                }
                array[i] /= 10;
            }
        }
        
        return answer;
    }
}