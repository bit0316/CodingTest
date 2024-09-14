using System;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";
        
        foreach (char ch in my_string)
        {
            answer += char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);
        }
        
        return answer;
    }
}