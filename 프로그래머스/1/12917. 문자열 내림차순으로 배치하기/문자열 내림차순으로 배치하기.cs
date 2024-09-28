using System;

public class Solution
{
    public string solution(string s)
    {
        char[] arr = s.ToCharArray();
        string answer;
        
        Array.Sort(arr);
        Array.Reverse(arr);
        answer = new string(arr);
        
        return answer;
    }
}