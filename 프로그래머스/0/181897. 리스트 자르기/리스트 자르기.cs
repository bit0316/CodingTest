using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n, int[] slicer, int[] num_list)
    {
        int[] answer;
        
        if (n == 1)
        {
            answer = GetSlice(0, slicer[1], 1, num_list);
        }
        else if (n == 2)
        {
            answer = GetSlice(slicer[0], num_list.Length - 1, 1, num_list);
        }
        else if (n == 3)
        {
            answer = GetSlice(slicer[0], slicer[1], 1, num_list);
        }
        else
        {
            answer = GetSlice(slicer[0], slicer[1], slicer[2], num_list);
        }
        
        return answer;
    }
    
    public int[] GetSlice(int start, int end, int space, int[] num_list)
    {
        List<int> list = new List<int>();
        
        for (int i = start; i <= end; i += space)
        {
            list.Add(num_list[i]);
        }
        
        return list.ToArray();
    }
}