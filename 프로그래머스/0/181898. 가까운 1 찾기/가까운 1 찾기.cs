using System;

public class Solution
{
    public int solution(int[] arr, int idx)
    {
        int answer = -1;
        int size = arr.Length;
        
        for (int i = idx; i < size; ++i)
        {
            if (arr[i] == 1)
            {
                answer = i;
                break;
            }
        }
        
        return answer;
    }
}