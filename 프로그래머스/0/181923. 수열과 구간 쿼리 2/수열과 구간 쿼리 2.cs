using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int size = queries.Length / 3;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] = int.MaxValue;
            for (int j = queries[i, 0]; j <= queries[i, 1]; ++j)
            {
                if (queries[i, 2] < arr[j] && answer[i] > arr[j])
                {
                    answer[i] = arr[j];
                }
            }
            if (answer[i] == int.MaxValue)
            {
                answer[i] = -1;
            }
        }
        
        return answer;
    }
}