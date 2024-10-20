using System;
using System.Collections.Generic;

public class Solution
{
    public int GRID_SIZE = 5;
    public Dictionary<char, (int, int)> DIRECTIONS = new Dictionary<char, (int, int)>
    {
        { 'U', (1, 0) }, { 'D', (-1, 0) }, { 'L', (0, -1) }, { 'R', (0, 1) }
    };
    
    public int solution(string dirs)
    {
        HashSet<(int, int, int, int)> hash = new HashSet<(int, int, int, int)>();
        int posX, posY;
        int curX, curY;
        
        posX = 0;
        posY = 0;
        foreach (char dir in dirs)
        {
            var direction = (DIRECTIONS[dir]);
            curX = posX + direction.Item1;
            curY = posY + direction.Item2;
            if (Math.Abs(curX) <= GRID_SIZE && Math.Abs(curY) <= GRID_SIZE)
            {
                Console.WriteLine("Input");
                hash.Add((posX, posY, curX, curY));
                hash.Add((curX, curY, posX, posY));
                posX = curX;
                posY = curY;
            }
        }
        
        return hash.Count / 2;
    }
}