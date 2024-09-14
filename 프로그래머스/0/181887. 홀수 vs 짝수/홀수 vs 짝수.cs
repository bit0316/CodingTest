using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int size = num_list.Length;
        int answer = 0;
        int even = 0;
        int odd = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (i % 2 == 0)
            {
                even += num_list[i];
            }
            else
            {
                odd += num_list[i];
            }
        }
        answer = even > odd ? even : odd;
        
        return answer;
    }
}