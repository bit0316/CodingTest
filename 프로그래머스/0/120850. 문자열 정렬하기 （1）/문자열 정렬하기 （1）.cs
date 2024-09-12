using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string my_string)
    {
        int[] answer;
        List<int> list = new List<int>();
        
        foreach (char ch in my_string)
        {
            if (ch >= '0' && ch <= '9')
            {
                list.Add(int.Parse(ch.ToString()));
            }
        }
        list.Sort();
        answer = list.ToArray();
        
        return answer;
    }
}