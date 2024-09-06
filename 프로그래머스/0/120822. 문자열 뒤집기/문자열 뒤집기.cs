using System;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";
        int size = my_string.Length;
        
        for (int i = size - 1; i >= 0; --i)
        {
            answer += my_string[i];
        }
        
        return answer;
    }
}