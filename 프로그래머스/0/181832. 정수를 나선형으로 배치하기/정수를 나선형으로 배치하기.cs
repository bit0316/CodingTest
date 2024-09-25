using System;

public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];
        int size = n * n;
        int minX = 0;
        int minY = 0;
        int maxX = n - 1;
        int maxY = n - 1;
        int posX = 0;
        int posY = 0;
        int num = 1;
        int index;
        
        while (minX < maxX && minY < maxY)
        {
            for (index = minX; index < maxX; ++index)
            {
                answer[posY, posX++] = num++;
            }
            for (index = minY; index < maxY; ++index)
            {
                answer[posY++, posX] = num++;
            }
            for (index = maxX; index > minX; --index)
            {
                answer[posY, posX--] = num++;
            }
            for (index = maxY; index > minY; --index)
            {
                answer[posY--, posX] = num++;
            }
            
            posX++;
            posY++;
            minX++;
            minY++;
            maxX--;
            maxY--;
        }
        
        if (minX == maxX && minY == maxY)
        {
            answer[n / 2, n / 2] = num;
        }
        
        return answer;
    }
}