using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int size = queries.Length / 2;
        int[] answer = arr;
        
        for (int i = 0; i < size; ++i)
        {
            for (int j = queries[i, 0]; j <= queries[i, 1]; ++j)
            {
                answer[j]++;
            }
        }
        
        return answer;
    }
}