using System;

public class Solution
{
    public string solution(string my_string, int m, int c)
    {
        string answer = "";
        int size = my_string.Length;
        
        for (int i = 0; i < size; i += m)
        {
            answer += my_string[i + c - 1];
        }
        
        return answer;
    }
}