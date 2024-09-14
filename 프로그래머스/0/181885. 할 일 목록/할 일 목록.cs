using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] todo_list, bool[] finished)
    {
        int size = todo_list.Length;
        List<string> list = new List<string>();
        string[] answer;
        
        for (int i = 0; i < size; ++i)
        {
            if (!finished[i])
            {
                list.Add(todo_list[i]);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}