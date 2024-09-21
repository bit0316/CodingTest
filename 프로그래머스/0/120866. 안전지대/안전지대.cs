using System;

public class Solution
{
    public (int, int)[] DIRECTIONS = 
    {
        (-1, -1), (-1, 0), (-1, 1),
        (0, -1), (0, 0), (0, 1),
        (1, -1), (1, 0), (1, 1)
    };
    
    public int solution(int[,] board)
    {
        int size = (int)Math.Sqrt(board.Length);
        int[,] map = new int[size, size];
        int answer = size * size;
        int posX, posY;
        
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (board[i, j] == 0)
                {
                    continue;
                }
                
                foreach (var dir in DIRECTIONS)
                {
                    posX = i + dir.Item1;
                    posY = j + dir.Item2;
                    if (posX >= 0 && posY >= 0 && posX < size && posY < size)
                    {
                        map[posX, posY] = 1;
                    }
                }
            }
        }
        
        foreach (int safe in map)
        {
            answer -= safe;
        }
        
        return answer;
    }
}