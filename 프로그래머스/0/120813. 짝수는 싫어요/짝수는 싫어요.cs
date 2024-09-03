using System;

public class Solution
{
    public int[] solution(int n)
    {
        int[] answer = new int[(n + 1) / 2];
        int size = answer.Length;
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] = i * 2 + 1;
        }
        
        return answer;
    }
}