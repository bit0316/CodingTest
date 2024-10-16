using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] elements)
    {
        HashSet<int> hash = new HashSet<int>();
        int size = elements.Length;
        int answer = 0;
        int sum;
        
        for(int i = 1; i <= size; ++i)
        {
            for(int j = 0; j < size; ++j)
            {
                sum = 0;
                for(int k = j; k < i + j; ++k)
                {
                    sum += elements[k % size];
                }
                hash.Add(sum);
            }
        }
        answer = hash.Count;
        
        return answer;
    }
}