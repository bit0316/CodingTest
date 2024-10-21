using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] order)
    {
        Stack<int> stack = new Stack<int>();
        int size = order.Length;
        int index = 0;
        
        for (int i = 1; i <= size; ++i)
        {
            if (order[index] != i)
            {
                stack.Push(i);
                continue;
            }
            
            index++;
            while (stack.Count > 0 && order[index] == stack.Peek())
            {
                index++;
                stack.Pop();
            }
        }
        while (stack.Count > 0 && order[index] == stack.Peek())
        {
            index++;
            stack.Pop();
        }
        
        return index;
    }
}