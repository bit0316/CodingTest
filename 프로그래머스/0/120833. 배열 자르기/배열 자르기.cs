using System;

public class Solution
{
    public int[] solution(int[] numbers, int num1, int num2)
    {
        int size = num2 - num1 + 1;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] = numbers[num1 + i];
        }
        
        return answer;
    }
}