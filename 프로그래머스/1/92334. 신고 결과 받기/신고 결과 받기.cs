using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        int size = id_list.Length;
        HashSet<string>[] list = new HashSet<string>[size];
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int[] count = new int[size];
        int[] answer = new int[size];
        string[] member;
        
        for (int i = 0; i < size; ++i)
        {
            list[i] = new HashSet<string>();
            dict.Add(id_list[i], i);
        }
        
        foreach (string str in report)
        {
            member = str.Split();
            list[dict[member[0]]].Add(member[1]);
        }
        
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (list[i].Contains(id_list[j]))
                {
                    count[j]++;
                }
            }
        }
        
        for (int i = 0; i < size; ++i)
        {
            if (count[i] >= k)
            {
                for (int j = 0; j < size; ++j)
                {
                    if (list[j].Contains(id_list[i]))
                    {
                        answer[j]++;
                    }
                }
            }
        }
        
        return answer;
    }
}