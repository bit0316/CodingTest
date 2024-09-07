using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int[] stk = new int[] {};
        Stack<int> stack = new Stack<int>();
        int index = 0;
        int size;
        
        while (index < arr.Length)
        {
            if (stack.Count == 0 || stack.Peek() < arr[index])
            {
                stack.Push(arr[index++]);
            }
            else
            {
                stack.Pop();
            }
        }
        
        size = stack.Count;
        stk = new int[size];
        for (int i = size - 1; i >= 0; --i)
        {
            stk[i] = stack.Pop();
        }
        
        return stk;
    }
}