using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;
        int size = myString.Length;
        
        for (int i = 0; i < size; ++i)
        {
            if (myString.Substring(i).StartsWith(pat))
            {
                answer++;
            }
        }
        
        return answer;
    }
}