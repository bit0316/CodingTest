using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        string[] possible = new string[] { "aya", "ye", "woo", "ma" };
        string[] impossible = new string[] { "ayaaya", "yeye", "woowoo", "mama" };
        int size = babbling.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            foreach (string str in impossible)
            {
                babbling[i] = babbling[i].Replace(str, "_");
            }
            
            foreach (string str in possible)
            {
                babbling[i] = babbling[i].Replace(str, " ");
            }
        }
        
        for (int i = 0; i < size; ++i)
        {
            if (babbling[i].Trim() == "")
            {
                answer++;
            }
        }
        
        return answer;
    }
}