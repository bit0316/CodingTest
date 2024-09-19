using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string myStr)
    {
        string str = myStr;
        List<string> list = new List<string>();
        string[] answer;
        string[] arr;
        int size;
        
        str = str.Replace("a", " ");
        str = str.Replace("b", " ");
        str = str.Replace("c", " ");
        arr = str.Trim().Split();
        
        size = arr.Length;
        for (int i = 0; i <size; ++i)
        {
            if (arr[i] != "")
            {
                list.Add(arr[i]);
            }
        }
        answer = list.Count > 0 ? list.ToArray() : new string[] { "EMPTY" };
        
        return answer;
    }
}