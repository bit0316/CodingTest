using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] park, string[] routes)
    {
        Dictionary<string, (int, int)> dict = new Dictionary<string, (int, int)>
        {
            { "N", (-1, 0) }, { "S", (1, 0) }, { "W", (0, -1) }, { "E", (0, 1) }
        };
        int[] answer = new int[2];
        int row = park.Length;
        int col = park[0].Length;
        int dirX, dirY;
        int curX, curY;
        int count;
        string[] str;
        
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (park[i][j] == 'S')
                {
                    answer[0] = i;
                    answer[1] = j;
                    break;
                }
            }
        }
        
        foreach (string route in routes)
        {
            str = route.Split();
            curX = answer[0];
            curY = answer[1];
            
            count = 0;
            dirX = dict[str[0]].Item1;
            for (int i = int.Parse(str[1]); i > 0; --i)
            {
                curX += dirX;
                if (curX < 0 || curX >= row || park[curX][curY] == 'X')
                {
                    curX = answer[0];
                    break;
                }
            }
            answer[0] = curX;

            count = 0;
            dirY = dict[str[0]].Item2;
            for (int i = int.Parse(str[1]); i > 0; --i)
            {
                curY += dirY;
                if (curY < 0 || curY >= col || park[curX][curY] == 'X')
                {
                    curY = answer[1];
                    break;
                }
            }
            answer[1] = curY;
        }
        
        return answer;
    }
}