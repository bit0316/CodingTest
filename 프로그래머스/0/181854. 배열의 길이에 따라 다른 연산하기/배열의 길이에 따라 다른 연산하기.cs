using System;

public class Solution
{
    public int[] solution(int[] arr, int n)
    {
        int size = arr.Length;
        int[] answer = arr;
        
        for (int i = (size + 1) % 2; i < size; i += 2)
        {
            answer[i] += n;
        }
        
        return answer;
    }
}