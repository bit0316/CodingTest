using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int[] answer;
        int size = num_list.Length;
        List<int> list = new List<int>();
        
        for (int i = 0; i < size; i += n)
        {
            list.Add(num_list[i]);
        }
        answer = list.ToArray();
        
        return answer;
    }
}