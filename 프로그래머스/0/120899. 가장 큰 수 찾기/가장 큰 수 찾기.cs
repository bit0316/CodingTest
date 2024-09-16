using System;

public class Solution
{
    public int[] solution(int[] array)
    {
        int size = array.Length;
        int[] answer = new int[2] { 0, int.MaxValue };
        
        for (int i = 0; i < size; ++i)
        {
            if (answer[0] < array[i])
            {
                answer[0] = array[i];
                answer[1] = i;
            }
        }
        
        return answer;
    }
}