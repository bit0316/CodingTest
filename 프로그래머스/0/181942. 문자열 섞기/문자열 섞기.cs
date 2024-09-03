using System;

public class Solution
{
    public string solution(string str1, string str2)
    {
        string answer = "";
        int size = str1.Length;
        
        for (int i = 0; i < size; ++i)
        {
            answer += str1[i];
            answer += str2[i];
        }
        
        return answer;
    }
}