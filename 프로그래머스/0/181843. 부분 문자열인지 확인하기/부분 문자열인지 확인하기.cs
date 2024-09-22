using System;

public class Solution
{
    public int solution(string my_string, string target)
    {
        int answer = my_string.Contains(target) ? 1 : 0;
        
        return answer;
    }
}