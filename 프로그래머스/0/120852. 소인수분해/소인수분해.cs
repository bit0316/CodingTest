using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        int[] answer;
        HashSet<int> set = new HashSet<int>();
        int index = 2;
        
        while (n > 1)
        {
            if (n % index == 0)
            {
                n /= index;
                set.Add(index);
                index = 2;
                continue;
            }
            index++;
        }
        
        index = 0;
        answer = new int[set.Count];
        foreach (int num in set)
        {
            answer[index++] = num;
        }
        
        return answer;
    }
}