using System;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int size = targets.Length;
        int[] counts = new int[26];
        int[] answer = new int[size];
        int index;
        
        Array.Fill(counts, int.MaxValue);
        foreach (string map in keymap)
        {
            for (int i = map.Length; i > 0; --i)
            {
                index = map[i - 1] - 'A';
                if (counts[index] > i)
                {
                    counts[index] = i;
                }
            }
        }
        
        for (int i = 0; i < size; ++i)
        {
            foreach (char ch in targets[i])
            {
                if (counts[ch - 'A'] == int.MaxValue)
                {
                    answer[i] = -1;
                    break;
                }
                answer[i] += counts[ch - 'A'];
            }
        }
        
        return answer;
    }
}