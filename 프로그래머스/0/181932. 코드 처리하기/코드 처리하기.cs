using System;

public class Solution
{
    public string solution(string code)
    {
        string answer = "";
        int size = code.Length;
        bool mode = false;
        
        for (int i = 0; i < size; ++i)
        {
            if (code[i] == '1')
            {
                mode = !mode;
            }
            else if ((!mode && i % 2 == 0) || (mode && i % 2 == 1))
            {
                answer += code[i];
            }
        }
        
        if (answer.Length == 0)
        {
            answer += "EMPTY";
        }
        
        return answer;
    }
}