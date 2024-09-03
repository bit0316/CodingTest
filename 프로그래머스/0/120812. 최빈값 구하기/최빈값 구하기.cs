using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        int max = 0;
        bool isValid = false;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach (int num in array)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }
        
        foreach (var item in dict)
        {
            if (max < item.Value)
            {
                answer = item.Key;
                max = item.Value;
                isValid = true;
            }
            else if (max == item.Value)
            {
                Console.WriteLine($"{dict[answer]}, {item.Value}");
                isValid = false;
            }
        }
        
        if (!isValid)
        {
            answer = -1;
        }
        
        return answer;
    }
}