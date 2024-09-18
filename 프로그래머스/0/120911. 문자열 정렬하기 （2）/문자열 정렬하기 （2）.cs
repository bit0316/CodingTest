using System;

public class Solution
{
    public string solution(string my_string)
    {
        char[] arr = my_string.ToLower().ToCharArray();
        string answer = "";
        
        Array.Sort(arr);
        answer = new string(arr);
        
        return answer;
    }
}