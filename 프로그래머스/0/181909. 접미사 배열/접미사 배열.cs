using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_string)
    {
        int size = my_string.Length;
        string[] answer = new string[size];
        List<string> list = new List<string>();
        
        for (int i = 0; i < size; ++i)
        {
            list.Add(my_string.Substring(i));
        }
        list.Sort();
        answer = list.ToArray();
        
        return answer;
    }
}