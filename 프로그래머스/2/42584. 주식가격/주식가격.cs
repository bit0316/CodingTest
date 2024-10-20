using System;

public class Solution
{
    public int[] solution(int[] prices)
    {
        int size = prices.Length;
        int[] answer = new int[size];
        int count;
        
        for (int i = 0; i < size; ++i)
        {
            count = 0;
            for (int j = i + 1; j < size; ++j)
            {
                count++;
                if (prices[i] > prices[j])
                {
                    break;
                }
            }
            answer[i] = count;
        }
        
        return answer;
    }
}