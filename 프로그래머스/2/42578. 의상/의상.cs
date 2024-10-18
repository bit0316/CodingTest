using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string[,] clothes)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int size = clothes.GetLength(0);
        int answer = 1;
        
        for (int i = 0; i < size; ++i)
        {
            if (dict.ContainsKey(clothes[i, 1]))
            {
                dict[clothes[i, 1]]++;
            }
            else
            {
                dict.Add(clothes[i, 1], 1);
            }
        }
        
        foreach (int cloth in dict.Values)
        {
            answer *= cloth + 1;
        }
        
        return answer - 1;
    }
}