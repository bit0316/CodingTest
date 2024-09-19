using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        Stack<int> stack = new Stack<int>();
        int size = arr.Length;
        int[] answer;
        
        for (int i = 0; i < size; ++i)
        {
            if (stack.Count == 0 || stack.Peek() != arr[i])
            {
                stack.Push(arr[i]);
            }
            else
            {
                stack.Pop();
            }
        }
        answer = stack.Count > 0 ? stack.ToArray() : new int[] { -1 };
        Array.Reverse(answer);
        
        return answer;
    }
}