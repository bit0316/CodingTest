using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int size = s.Length;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], i);
                answer[i] = -1;
            }
            else
            {
                answer[i] = i - dict[s[i]];
                dict[s[i]] = i;
            }
        }
        
        return answer;
    }
}