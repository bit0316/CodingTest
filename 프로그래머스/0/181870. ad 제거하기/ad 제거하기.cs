using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] strArr)
    {
        string check = "ad";
        List<string> list = new List<string>();
        int size = strArr.Length;
        string[] answer;
        
        for (int i = 0; i < size; ++i)
        {
            if (!strArr[i].Contains(check))
            {
                list.Add(strArr[i]);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}