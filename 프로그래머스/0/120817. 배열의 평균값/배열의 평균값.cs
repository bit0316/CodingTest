using System;

public class Solution
{
    public double solution(int[] numbers)
    {
        double answer = 0;
        int size = numbers.Length;
        
        for (int i = 0; i < size; ++i)
        {
            answer += numbers[i];
        }
        answer /= size;
        
        return answer;
    }
}