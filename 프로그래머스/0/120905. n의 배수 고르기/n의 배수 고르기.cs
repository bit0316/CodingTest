using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n, int[] numlist)
    {
        List<int> list = new List<int>();
        int[] answer;
        
        foreach (int num in numlist)
        {
            if (num % n == 0)
            {
                list.Add(num);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}