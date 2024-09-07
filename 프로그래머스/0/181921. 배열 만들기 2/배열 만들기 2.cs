using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int l, int r)
    {
        int[] answer = new int[] { -1 };
        List<int> list = new List<int>();
        int left = l % 5 == 0 ? l : l - l % 5 + 5;
        int right = r % 5 == 0 ? r : r - r % 5;
        string numStr;
        
        for (int i = left; i <= right; i += 5)
        {
            numStr = i.ToString();
            if (IsValid(numStr))
            {
                list.Add(i);
            }
        }
        if (list.Count > 0)
        {
            answer = list.ToArray();
        }
        
        return answer;
    }
    
    public bool IsValid(string numStr)
    {
        foreach (char ch in numStr)
        {
            if (int.Parse(ch.ToString()) % 5 != 0)
            {
                return false;
            }
        }
        return true;
    }
}