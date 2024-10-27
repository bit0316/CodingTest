using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string number, int k)
    {
        Stack<char> stack = new Stack<char>();
        int count = 0;
        char[] arr;
        int size;
        
        foreach (char ch in number)
        {
            while (count < k && stack.Count > 0 && stack.Peek() < ch)
            {
                stack.Pop();
                count++;
            }
            stack.Push(ch);
        }
        
        while (count < k && stack.Count > 0)
        {
            stack.Pop();
            count++;
        }
        
        size = stack.Count;
        arr = new char[size];
        for (int i = size - 1; i >= 0; --i)
        {
            arr[i] = stack.Pop();
        }
        
        return new string(arr);
    }
}