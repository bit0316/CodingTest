using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string myString)
    {
        string[] answer = myString.Trim('x').Split('x');
        List<string> list = new List<string>();

        foreach (string str in answer)
        {
            if (str != "")
            {
                list.Add(str);
            }
        }
        list.Sort();
        answer = list.ToArray();
        
        return answer;
    }
}