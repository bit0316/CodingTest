using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] numbers, int target)
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        int size = numbers.Length;
        int answer = 0;
        int total = 0;
        int index = 0;
        
        stack.Push((total + numbers[index], index + 1));
        stack.Push((total - numbers[index], index + 1));
        while (stack.Count > 0)
        {
            (total, index) = stack.Pop();
            if (index < size)
            {
                stack.Push((total + numbers[index], index + 1));
                stack.Push((total - numbers[index], index + 1));
                continue;
            }
            
            if (total == target)
            {
                answer++;
            }
        }
        
        return answer;
    }
}