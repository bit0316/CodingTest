using System;

public class Solution
{
    public int solution(int[] a, int[] b)
    {
        int size = a.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            answer += a[i] * b[i];
        }
        
        return answer;
    }
}