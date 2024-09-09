using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string my_string, string is_suffix)
    {
        int answer = 0;
        int size = my_string.Length;
        HashSet<string> set = new HashSet<string>();
        
        for (int i = 0; i < size; ++i)
        {
            set.Add(my_string.Substring(i));
        }
        answer = set.Contains(is_suffix) ? 1 : 0;
        
        return answer;
    }
}