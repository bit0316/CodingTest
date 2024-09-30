using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        List<int> list = new List<int>();
        int size = score.Length;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            if (list.Count >= k)
            {
                if (score[i] < list[0])
                {
                    answer[i] = list[0];
                    continue;
                }
                list.RemoveAt(0);
            }
            list.Add(score[i]);
            list.Sort();
            answer[i] = list[0];
        }
        
        return answer;
    }
}