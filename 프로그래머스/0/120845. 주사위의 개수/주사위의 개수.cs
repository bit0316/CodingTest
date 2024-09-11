using System;

public class Solution
{
    public int solution(int[] box, int n)
    {
        int answer = 1;
        int size = box.Length;
        
        for (int i = 0; i < size; ++i)
        {
            answer *= box[i] / n;
        }
        
        return answer;
    }
}