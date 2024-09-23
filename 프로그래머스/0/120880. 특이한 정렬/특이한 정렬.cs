using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numlist, int n)
    {
        SortedDictionary<int, int> sd = new SortedDictionary<int, int>();
        int size = numlist.Length;
        int[] answer = new int[size];
        int order;
        
        foreach (int num in numlist)
        {
            order = num - n > 0 ? 0 : 1;
            sd.Add(order + Math.Abs(num - n) * 2, num);
        }
        answer = sd.Values.ToArray();
        
        return answer;
    }
}