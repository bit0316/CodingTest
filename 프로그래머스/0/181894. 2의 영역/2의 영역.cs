using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int[] answer = new int[] { -1 };
        int size = arr.Length;
        int left = -1;
        int right = -1;
        List<int> list = new List<int>();
        
        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == 2)
            {
                if (left == -1)
                {
                    left = i;
                    right = i;
                }
                else
                {
                    right = i;
                }
            }
        }
        
        if (left != -1)
        {
            for (int i = left; i <= right; ++i)
            {
                list.Add(arr[i]);
            }
            answer = list.ToArray();
        }
        
        return answer;
    }
}