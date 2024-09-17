using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_string)
    {
        string[] answer = my_string.Trim().Split();
        List<string> list = new List<string>();
        
        foreach (string str in answer)
        {
            if (str != "")
            {
                list.Add(str);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}