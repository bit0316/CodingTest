using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int num)
    {
        HashSet<long> set = new HashSet<long>();
        long collatz = num;
        int answer = 0;
        
        while (collatz != 1)
        {
            collatz = collatz % 2 == 0 ? collatz / 2 : collatz * 3 + 1;
            if (set.Contains(collatz) || answer == 500)
            {
                answer = -1;
                break;
            }
            set.Add(collatz);
            answer++;
        }
        
        return answer;
    }
}