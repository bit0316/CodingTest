using System;

public class Solution
{
    public int solution(int[,] board, int k)
    {
        int row = board.GetLength(0);
        int col = board.GetLength(1);
        int answer = 0;
        
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                if (i + j <= k)
                {
                    answer += board[i, j];
                }
            }
        }
        
        return answer;
    }
}