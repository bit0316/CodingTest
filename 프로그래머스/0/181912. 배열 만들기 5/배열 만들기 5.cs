using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] intStrs, int k, int s, int l)
    {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        int size = intStrs.Length;
        int num;
        
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(intStrs[i].Substring(s, l));
            if (num > k)
            {
                list.Add(num);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}