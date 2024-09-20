using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int size = numbers.Length;
        int answer = 0;
        
        if (size == 2)
        {
            answer = numbers[0] * numbers[1];
        }
        else
        {
            Array.Sort(numbers);
            answer = Math.Max(answer, numbers[0] * numbers[1]);
            answer = Math.Max(answer, numbers[size - 1] * numbers[size - 2]);
        }
        
        return answer;
    }
}