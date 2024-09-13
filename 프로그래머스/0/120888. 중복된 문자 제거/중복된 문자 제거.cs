using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";
        int size = my_string.Length;
        HashSet<char> set = new HashSet<char>();
        int index = 0;
        
        foreach (char ch in my_string)
        {
            if (!set.Contains(ch))
            {
                set.Add(ch);
                answer += ch;
            }
        }
        
        return answer;
    }
}