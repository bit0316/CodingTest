using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int row = arr1.GetLength(0);
        int col = arr2.GetLength(1);
        int mul = arr2.GetLength(0);
        int[,] answer = new int[row, col];
        
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < col; ++j)
            {
                for (int k = 0; k < mul; ++k)
                {
                    answer[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        
        return answer;
    }
}