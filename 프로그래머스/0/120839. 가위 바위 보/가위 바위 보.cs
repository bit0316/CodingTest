using System;

public class Solution
{
    public string solution(string rsp)
    {
        string answer = "";
        int size = rsp.Length;
        
        for (int i = 0; i < size; ++i)
        {
            if (rsp[i] == '2')
            {
                answer += "0";
            }
            else if (rsp[i] == '0')
            {
                answer += "5";
            }
            else
            {
                answer += "2";
            }
        }
        
        return answer;
    }
}