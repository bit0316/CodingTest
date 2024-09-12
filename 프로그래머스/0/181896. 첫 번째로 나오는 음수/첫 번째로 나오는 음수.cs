using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = -1;
        int size = num_list.Length;
        
        for (int i = 0; i < size; ++i)
        {
            if (num_list[i] < 0)
            {
                answer = i;
                break;
            }
        }
        
        return answer;
    }
}