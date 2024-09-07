using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = new int[arr.Length];
        int size = queries.Length / 3;
        
        for (int i = 0; i < size; ++i)
        {
            for (int j = queries[i, 0]; j <= queries[i, 1]; ++j)
            {
                if (j % queries[i, 2] == 0)
                {
                    arr[j]++;
                }
            }
        }
        answer = arr;
        
        return answer;
    }
}