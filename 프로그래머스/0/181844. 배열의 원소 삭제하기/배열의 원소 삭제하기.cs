using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[] delete_list)
    {
        List<int> list = new List<int>(arr);
        int[] answer;
        
        foreach (int num in delete_list)
        {
            if (list.Contains(num))
            {
                list.Remove(num);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}