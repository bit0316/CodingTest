using System;

public class Solution
{
    public int solution(string[] s1, string[] s2)
    {
        int answer = 0;

        foreach (string str1 in s1)
        {
            foreach (string str2 in s2)
            {
                if (str1 == str2)
                {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}