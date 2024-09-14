using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] names)
    {
        int group = 5;
        int size = names.Length;
        List<string> list = new List<string>();
        string[] answer;
        
        for (int i = 0; i < size; i += group)
        {
            list.Add(names[i]);
        }
        answer = list.ToArray();
        
        return answer;
    }
}