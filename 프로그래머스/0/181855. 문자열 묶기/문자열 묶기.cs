using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string[] strArr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int answer = 0;
        int length;
        
        foreach (string str in strArr)
        {
            length = str.Length;
            if (dict.ContainsKey(length))
            {
                dict[length]++;
            }
            else
            {
                dict.Add(length, 1);
            }
        }
        answer = dict.Values.Max();
        
        return answer;
    }
}