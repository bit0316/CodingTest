using System;

public class Solution
{
    public long[] solution(long[] numbers)
    {
        int size = numbers.Length;
        long[] answer = numbers;
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] += ((numbers[i] ^ (numbers[i] + 1)) >> 2) + 1;
        }
        
        return answer;
    }
}