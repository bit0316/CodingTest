using System;
using System.Collections.Generic;

public class Solution
{
    const int DISCOUNT_DAYS = 10;
    
    public int solution(string[] want, int[] number, string[] discount)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int size = want.Length;
        int days = discount.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            dict.Add(want[i], number[i]);
        }
        
        for (int i = 0; i < DISCOUNT_DAYS; ++i)
        {
            if (dict.ContainsKey(discount[i]))
            {
                dict[discount[i]]--;
            }
        }
        if (IsValid(dict))
        {
            answer++;
        }
        
        for (int i = DISCOUNT_DAYS; i < days; ++i)
        {
            if (dict.ContainsKey(discount[i - DISCOUNT_DAYS]))
            {
                dict[discount[i - DISCOUNT_DAYS]]++;
            }
            if (dict.ContainsKey(discount[i]))
            {
                dict[discount[i]]--;
            }
            if (IsValid(dict))
            {
                answer++;
            }
        }
        
        return answer;
    }
    
    public bool IsValid(Dictionary<string, int> dict)
    {
        foreach (int count in dict.Values)
        {
            if (count > 0)
            {
                return false;
            }
        }
        return true;
    }
}