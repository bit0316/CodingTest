using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[,] score)
    {
        int size = score.Length / 2;
        int[] answer = new int[size];
        
        Array.Fill(answer, 1);
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
               if (score[i,0] + score[i,1] > score[j,0] + score[j,1])
               {
                   answer[j]++;
               }
            }
        }
        
        return answer;
    }
}