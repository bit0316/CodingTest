using System;

public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        int count = brown + yellow;
        int start = 3;
        int end = count / 3;
        
        for (int i = start; i <= end; ++i)
        {
            for (int j = start; j <= end; ++j)
            {
                if (i * j == count && (i - 2) * (j - 2) == yellow && i >= j)
                {
                    answer[0] = i;
                    answer[1] = j;
                    
                    return answer;
                }
            }
        }
          
        return answer;
    }
}