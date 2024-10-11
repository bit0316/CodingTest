using System;

public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;
        int count = 0;
        
        foreach (char ch in s)
        {
            count += ch == '(' ? 1 : -1;
            if (count < 0)
            {
                answer = false;
                break;
            }
        }
        if (count != 0)
        {
            answer = false;
        }
        
        return answer;
    }
}