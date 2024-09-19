using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        int size = array.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (array[i] == n)
            {
                answer++;
            }
        }
        
        return answer;
    }
}