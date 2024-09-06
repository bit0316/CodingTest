using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = new int[arr.Length];
        int size = queries.Length / 2;
        int temp;
        
        for (int i = 0; i < size; ++i)
        {
            temp = arr[queries[i, 0]];
            arr[queries[i, 0]] = arr[queries[i, 1]];
            arr[queries[i, 1]] = temp;
        }
        answer = arr;
        
        return answer;
    }
}