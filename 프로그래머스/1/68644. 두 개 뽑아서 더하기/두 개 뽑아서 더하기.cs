using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        HashSet<int> set = new HashSet<int>();
        int size = numbers.Length;
        int[] answer;
        
        for (int i = 0; i < size - 1; ++i)
        {
            for (int j = i + 1; j < size; ++j)
            {
                set.Add(numbers[i] + numbers[j]);
            }
        }
        answer = set.ToArray();
        Array.Sort(answer);
        
        return answer;
    }
}