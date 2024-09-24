using System;

public class Solution
{
    public string solution(string myString)
    {
        int size = myString.Length;
        string answer = "";
        
        for (int i = 0; i < size; ++i)
        {
            answer += myString[i] < 'l' ? 'l' : myString[i];
        }
        
        return answer;
    }
}