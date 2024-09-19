using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, bool[] flag)
    {
        Stack<int> stack = new Stack<int>();
        int size = arr.Length;
        int[] answer;
        
        for (int i = 0; i < size; ++i)
        {
            if (flag[i])
            {
                for (int j = 2 * arr[i]; j > 0; --j)
                {
                    stack.Push(arr[i]);
                }
            }
            else
            {
                for (int j = arr[i]; j > 0; --j)
                {
                    stack.Pop();
                }
            }
        }
        answer = stack.ToArray();
        Array.Reverse(answer);
        
        return answer;
    }
}