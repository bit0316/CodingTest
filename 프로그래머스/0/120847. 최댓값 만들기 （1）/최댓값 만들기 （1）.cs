using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = 0;
        int size = numbers.Length;
        int first = 0;
        int second = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (first <= numbers[i])
            {
                second = first;
                first = numbers[i];
            }
            else if (second < numbers[i])
            {
                second = numbers[i];
            }
        }
        answer = first * second;
        
        return answer;
    }
}