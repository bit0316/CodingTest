using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int answer = 0;
        int sum = 0;
        int[] arr;
        
        foreach (int size in tangerine)
        {
            if (dict.ContainsKey(size))
            {
                dict[size]++;
            }
            else
            {
                dict.Add(size, 1);
            }
        }
        
        arr = dict.Values.ToArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        foreach (int count in arr)
        {
            answer++;
            sum += count;
            if (sum >= k)
            {
                break;
            }
        }
        
        return answer;
    }
}