using System;

public class Solution
{
    public int solution(string num_str)
    {
        int answer = 0;
        
        foreach (char ch in num_str)
        {
            answer += int.Parse(ch.ToString());
        }
        
        return answer;
    }
}