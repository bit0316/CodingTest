using System;
using System.Collections.Generic;

public class Solution
{
    public Dictionary<char, char> dict = new Dictionary<char, char>
    {
        {  '(', ')' }, { '[', ']' }, { '{', '}' }
    };
    
    public int solution(string s)
    {
        Queue<char> queue = new Queue<char>(s);
        int size = s.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (IsValid(queue))
            {
                answer++;
            }
            queue.Enqueue(queue.Dequeue());
        }
        
        return answer;
    }
    
    public bool IsValid(Queue<char> original)
    {
        Queue<char> queue = new Queue<char>(original);
        Stack<char> stack = new Stack<char>();
        int size = queue.Count;
        char ch;
        
        while (queue.Count > 0)
        {
            ch = queue.Dequeue();
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if (stack.Count > 0 && ch == dict[stack.Peek()])
            {
                stack.Pop();
            }
            else
            {
                
                return false;
            }
        }
        return stack.Count == 0 ? true : false;
    }
}