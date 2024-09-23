using System;

public class Solution
{
    string[] arr = new string[] { "aya", "ye", "woo", "ma" };

    public int solution(string[] babbling)
    {
        int size = babbling.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            foreach (string str in arr)
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