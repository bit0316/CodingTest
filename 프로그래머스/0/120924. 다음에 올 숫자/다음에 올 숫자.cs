using System;

public class Solution
{
    public int solution(int[] common)
    {
        int size = common.Length;
        int answer = 0;
        
        if (IsArithmetic(common))
        {
            answer = common[size - 1] + common[1] - common[0];
        }
        else
        {
            answer = common[size - 1] * (common[1] / common[0]);
        }
        
        return answer;
    }
    
    public bool IsArithmetic(int[] arr)
    {
        int size = arr.Length;
        
        for (int i = 2; i < size; ++i)
        {
            if (arr[i] - arr[i - 1] != arr[i - 1] - arr[i - 2])
            {
                return false;
            }
        }
        return true;
    }
}