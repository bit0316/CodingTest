using System;

public class Solution
{
    public int solution(string str1, string str2)
    {
        int answer = str1.Contains(str2) ? 1 : 2;
        
        return answer;
    }
}