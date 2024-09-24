using System;

public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        int size = arr.Length;
        int[] answer = new int[size];
        
        if (k % 2 == 1)
        {
            for (int i = 0; i < size; ++i)
            {
                answer[i] = arr[i] * k;
            }
        }
        else
        {
            for (int i = 0; i < size; ++i)
            {
                answer[i] = arr[i] + k;
            }
        }
        
        return answer;
    }
}