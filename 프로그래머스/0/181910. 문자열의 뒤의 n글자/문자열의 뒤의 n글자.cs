using System;

public class Solution
{
    public string solution(string my_string, int n)
    {
        string answer = "";
        int size = my_string.Length;
        
        answer = my_string.Substring(size - n);
        
        return answer;
    }
}