using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> list = new List<int>();
        int size = progresses.Length;
        int index = 0;
        int count;
        
        while (index < size)
        {
            for (int i = index; i < size; ++i)
            {
                progresses[i] += speeds[i];
            }
            
            if (progresses[index] < 100)
            {
                continue;
            }
            
            count = 0;
            while (index < size && progresses[index] >= 100)
            {
                index++;
                count++;
            }
            list.Add(count);
        }
        
        return list.ToArray();
    }
}