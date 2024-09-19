using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> list = new List<int>();
        int size = arr.Length;
        int[] answer;
        
        for (int i = 0; i < size; ++i)
        {
            for (int j = arr[i]; j > 0; --j)
            {
                list.Add(arr[i]);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}