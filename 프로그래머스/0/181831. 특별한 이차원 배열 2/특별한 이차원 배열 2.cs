using System;

public class Solution
{
    public int solution(int[,] arr)
    {
        int answer = IsValid(arr) ? 1 : 0;
        
        return answer;
    }
    
    public bool IsValid(int[,] arr)
    {
        int size = arr.GetLength(0);
        
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (arr[i, j] != arr[j, i])
                {
                    return false;
                }
            }
        }
        return true;
    }
}