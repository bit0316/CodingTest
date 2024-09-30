using System;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        int size = strings.Length;
        string[] answer = new string[size];
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] += strings[i][n] + strings[i];
        }
        
        Array.Sort(answer);
        for (int i = 0; i < size; ++i)
        {
            answer[i] = answer[i].Substring(1);
        }
        
        return answer;
    }
}