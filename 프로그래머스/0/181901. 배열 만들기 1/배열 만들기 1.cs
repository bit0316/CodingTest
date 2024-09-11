using System;

public class Solution
{
    public int[] solution(int n, int k)
    {
        int[] answer = new int[n / k];
        int index = 0;
        
        for (int i = k; i <= n; i += k)
        {
            answer[index++] = i;
        }
        
        return answer;
    }
}