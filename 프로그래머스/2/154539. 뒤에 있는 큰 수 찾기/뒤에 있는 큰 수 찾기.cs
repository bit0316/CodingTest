using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        Stack<int> stack = new Stack<int>();
        int size = numbers.Length;
        int[] answer = new int[size];
        
        Array.Fill(answer, -1);
        for (int i = size - 1; i >= 0; --i)
        {
            while (stack.Count > 0 && stack.Peek() <= numbers[i])
            {
                stack.Pop();
            }
            
            if (stack.Count > 0)
            {
                answer[i] = stack.Peek();
            }

            stack.Push(numbers[i]);
        }
        
        return answer;
    }
}