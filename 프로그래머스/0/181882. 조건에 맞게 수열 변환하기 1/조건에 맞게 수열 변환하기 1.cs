using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int point = 50;
        int size = arr.Length;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            if (arr[i] >= point && arr[i] % 2 == 0)
            {
                answer[i] = arr[i] / 2;
            }
            else if (arr[i] < point && arr[i] % 2 == 1)
            {
                answer[i] = arr[i] * 2;
            }
            else
            {
                answer[i] = arr[i];
            }
        }
        
        return answer;
    }
}