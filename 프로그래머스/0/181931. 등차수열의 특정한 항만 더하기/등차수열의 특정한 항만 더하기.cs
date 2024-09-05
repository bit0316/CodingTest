using System;

public class Solution
{
    public int solution(int a, int d, bool[] included)
    {
        int answer = 0;
        int size = included.Length;
        
        for (int i = 0; i < size; ++i)
        {
            if (included[i])
            {
                answer += a + i * d;
            }
        }
        
        return answer;
    }
}