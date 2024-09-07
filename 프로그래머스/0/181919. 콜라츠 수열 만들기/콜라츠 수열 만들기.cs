using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        
        list.Add(n);
        while (n != 1)
        {
            n = n % 2 == 0 ? n / 2 : 3 * n + 1;
            list.Add(n);
        }
        answer = list.ToArray();
        
        return answer;
    }
}