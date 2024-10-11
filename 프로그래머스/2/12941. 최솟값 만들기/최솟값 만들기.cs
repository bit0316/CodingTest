using System;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        int size = A.Length;
        int answer = 0;
        
        Array.Sort(A);
        Array.Sort(B);
        for (int i = 0; i < size; ++i)
        {
            answer += A[i] * B[size - i - 1];
        }
        
        return answer;
    }
}