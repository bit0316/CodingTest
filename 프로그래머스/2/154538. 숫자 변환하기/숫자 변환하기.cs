using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int x, int y, int n)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        bool[] visited = new bool[y + 1];
        int num, count;
        
        queue.Enqueue((y, 0));
        while (queue.Count > 0)
        {
            (num, count) = queue.Dequeue();
            if (num == x)
            {
                return count;
            }
            if (num > x && !visited[num])
            {
                queue.Enqueue((num - n, count + 1));
                if (num % 2 == 0)
                {
                    queue.Enqueue((num / 2, count + 1));
                }
                if (num % 3 == 0)
                {
                    queue.Enqueue((num / 3, count + 1));
                }
            }
        }
        
        return -1;
    }
}