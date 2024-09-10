using System;

public class Solution
{
    public int[] solution(int[] numbers, string direction)
    {
        int size = numbers.Length;
        int[] answer = new int[size];
        
        if (direction == "right")
        {
            answer[0] = numbers[size - 1];
            for (int i = 1; i < size; ++i)
            {
                answer[i] = numbers[i - 1];
            }
        }
        else
        {
            answer[size - 1] = numbers[0];
            for (int i = 0; i < size - 1; ++i)
            {
                answer[i] = numbers[i + 1];
            }
        }
        
        return answer;
    }
}