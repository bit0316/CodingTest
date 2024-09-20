using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int size = arr.Length;
        int length = 1;
        int[] answer;
        
        while (length < size)
        {
            length *= 2;
        }
        
        answer = new int[length];
        for (int i = 0; i < size; ++i)
        {
            answer[i] = arr[i];
        }
        
        return answer;
    }
}