using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;
        int even = 0;
        int odd = 0;
        
        foreach (int num in num_list)
        {
            if (num % 2 == 0)
            {
                even = even * 10 + num;
            }
            else
            {
                odd = odd * 10 + num;
            }
        }
        answer = even + odd;
        
        return answer;
    }
}