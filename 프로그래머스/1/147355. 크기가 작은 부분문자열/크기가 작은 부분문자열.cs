using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int length = p.Length;
        int size = t.Length - length + 1;
        long numP = long.Parse(p);
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (long.Parse(t.Substring(i, length)) <= numP)
            {
                answer++;
            }
        }
        
        return answer;
    }
}