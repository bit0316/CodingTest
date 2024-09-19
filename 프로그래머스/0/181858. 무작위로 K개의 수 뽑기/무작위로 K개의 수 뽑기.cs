using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        HashSet<int> set = new HashSet<int>();
        int[] answer = new int[k];
        int size = arr.Length;
        int index = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (!set.Contains(arr[i]) && index < k)
            {
                set.Add(arr[i]);
                answer[index++] = arr[i];
            }
        }
        
        for (int i = index; i < k; ++i)
        {
            answer[i] = -1;
        }
        
        return answer;
    }
}