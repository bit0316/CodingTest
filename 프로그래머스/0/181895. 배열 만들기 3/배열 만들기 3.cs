using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[,] intervals)
    {
        int[] answer;
        List<int> list = new List<int>();
        
        for (int i = intervals[0, 0]; i <= intervals[0, 1]; ++i)
        {
            list.Add(arr[i]);
        }
        for (int i = intervals[1, 0]; i <= intervals[1, 1]; ++i)
        {
            list.Add(arr[i]);
        }
        answer = list.ToArray();
        
        return answer;
    }
}