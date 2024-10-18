using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] priorities, int location)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int size = priorities.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            queue.Enqueue((i, priorities[i]));
        }
        
        int max;
        int position;
        int priority;
        while(true)
        {
            max = queue.Max(element => element.Item2);
            (position, priority) = queue.Dequeue();
            if (priority == max)
            {
                answer++;
                if (position == location)
                {
                    break;
                }
                continue;
            }
            queue.Enqueue((position, priority));
        }
        
        return answer;
    }
}