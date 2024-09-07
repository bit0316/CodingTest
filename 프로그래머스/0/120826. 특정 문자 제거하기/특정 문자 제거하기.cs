using System;

public class Solution
{
    public string solution(string my_string, string letter)
    {
        string answer = "";
        int size = my_string.Length;
        
        for (int i = 0; i < size; ++i)
        {
            if (my_string[i] != letter[0])
            {
                answer += my_string[i];
            }
        }
        
        return answer;
    }
}