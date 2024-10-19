using System;
using System.Collections.Generic;

class Solution
{
    public (int, int)[] DIRECTIONS = { (0, -1), (0, 1), (-1, 0), (1, 0) };
    
    public int solution(int[,] maps)
    {
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        int row = maps.GetLength(0);
        int col = maps.GetLength(1);
        bool[,] visited = new bool[row, col];
        int posX = 0;
        int posY = 0;
        int move = 0;
        int curX, curY;
        
        queue.Enqueue((posX, posY, move + 1));
        visited[posX, posY] = true;
        while (queue.Count > 0)
        {
            (posX, posY, move) = queue.Dequeue();
            maps[posX, posY] = move;
            foreach (var dir in DIRECTIONS)
            {
                curX = posX + dir.Item1;
                curY = posY + dir.Item2;
                if (curX >= 0 && curY >= 0 && curX < row && curY < col &&
                    maps[curX, curY] == 1 && !visited[curX, curY])
                {
                    queue.Enqueue((curX, curY, move + 1));
                    visited[curX, curY] = true;
                }
            }
        }
        
        return visited[row - 1, col - 1] ? maps[row - 1, col - 1] : -1;
    }
}