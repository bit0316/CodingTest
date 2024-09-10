using System;

public class Solution
{
    public string solution(int q, int r, string code)
    {
        string answer = "";
        int size = code.Length;
        
        for (int i =r; i < size; i += q)
        {
            answer += code[i];
        }
        
        return answer;
    }
}