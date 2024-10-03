using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string X, string Y)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        List<char> list = new List<char>();
        string answer = "-1";
        
        foreach (char ch in X)
        {
            if (dict.ContainsKey(ch))
            {
                dict[ch]++;
            }
            else
            {
                dict.Add(ch, 1);
            }
        }
        
        foreach (char ch in Y)
        {
            if (dict.ContainsKey(ch) && dict[ch] > 0)
            {
                list.Add(ch);
                dict[ch]--;
            }
        }
        
        if (list.Count > 0)
        {
            if (list.Max() == '0')
            {
                answer = "0";
            }
            else
            {
                list.Sort();
                list.Reverse();
                answer = new string(list.ToArray());
            }
        }
        
        return answer;
    }
}