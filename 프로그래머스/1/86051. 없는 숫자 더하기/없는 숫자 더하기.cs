using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] numbers)
    {
        HashSet<int> set = new HashSet<int>();
        int answer = 0;
        
        foreach (int num in numbers)
        {
            set.Add(num);
        }
        
        for (int i = 1; i <= 9; ++i)
        {
            if (!set.Contains(i))
            {
                answer += i;
            }
        }
        
        return answer;
    }
}