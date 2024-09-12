using System;

public class Solution
{
    public int[] solution(int[] arr, int[] query)
    {
        int[] answer;
        int size = query.Length;
        int left = 0;
        int right = arr.Length - 1;
        int index = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (i % 2 == 0)
            {
                right = left + query[i];
            }
            else
            {
                left += query[i];
            }
        }
        
        answer = new int[right - left + 1];
        for (int i = left; i <= right; ++i)
        {
            answer[index++] = arr[i];
        }
        
        return answer;
    }
}