using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] friends, string[] gifts)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int size = friends.Length;
        int[,] arr = new int[size, size];
        int[] score = new int[size];
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            dict.Add(friends[i], i);
        }
        
        string[] member;
        foreach (string gift in gifts)
        {
            member = gift.Split();
            arr[dict[member[0]], dict[member[1]]]++;
            score[dict[member[0]]]--;
            score[dict[member[1]]]++;
        }
        
        int count;
        for (int i = 0; i < size; ++i)
        {
            count = 0;
            for (int j = 0; j < size; ++j)
            {
                if (i != j && (arr[i, j] > arr[j, i] || 
                    (arr[i, j] == arr[j, i]) && score[i] < score[j]))
                {
                    count++;
                }
            }
            answer = Math.Max(answer, count);
        }
        
        return answer;
    }
}