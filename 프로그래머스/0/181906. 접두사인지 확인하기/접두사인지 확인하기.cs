using System;

public class Solution
{
    public int solution(string my_string, string is_prefix)
    {
        int answer = 0;
        
        if (my_string.Length >= is_prefix.Length)
        {
            answer = my_string.Substring(0, is_prefix.Length) == is_prefix ? 1 : 0;
        }
        
        return answer;
    }
}