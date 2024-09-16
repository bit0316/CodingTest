using System;

public class Solution
{
    public string solution(string myString)
    {
        string answer = myString.ToLower().Replace("a", "A");
        
        return answer;
    }
}