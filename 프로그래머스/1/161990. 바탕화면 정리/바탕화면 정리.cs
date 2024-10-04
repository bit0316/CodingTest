using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int row = wallpaper.Length;
        int col = wallpaper[0].Length;
        int[] answer = new int[] { row, col, 0, 0 };
        
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (wallpaper[i][j] == '#')
                {
                    answer[0] = Math.Min(answer[0], i);
                    answer[1] = Math.Min(answer[1], j);
                    answer[2] = Math.Max(answer[2], i + 1);
                    answer[3] = Math.Max(answer[3], j + 1);
                }
            }
        }
        
        return answer;
    }
}