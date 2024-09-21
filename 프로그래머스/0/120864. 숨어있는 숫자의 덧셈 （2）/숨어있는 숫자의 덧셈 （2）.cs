using System;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;
        int num = 0;
        
        my_string += " ";
        foreach (char ch in my_string)
        {
            if (Char.IsDigit(ch))
            {
                num = num * 10 + ch - '0';
            }
            else
            {
                answer += num;
                num = 0;
                
            }
        }
        
        return answer;
    }
}