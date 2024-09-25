using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string A, string B)
    {
        int answer = GetResult(A, B);
        
        return answer;
    }
    
    public int GetResult(string A, string B)
    {
        Queue<char> queue = new Queue<char>();
        int size = A.Length;
        string str;
        char ch;
        
        for (int i = 0; i < size; ++i)
        {
            queue.Enqueue(B[i]);
        }
        
        for (int i = 0; i < size; ++i)
        {
            str = "";
            for (int j = 0; j < size; ++j)
            {
                ch = queue.Dequeue();
                queue.Enqueue(ch);
                str += ch;
            }
            if (A == str)
            {
                return i;
            }
            queue.Enqueue(queue.Dequeue());
        }
        
        return -1;
    }
}