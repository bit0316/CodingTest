using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int size = num_list.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            while (num_list[i] != 1)
            {
                num_list[i] = num_list[i] % 2 == 0 ? num_list[i] / 2 : (num_list[i] - 1) / 2;
                answer++;
            }
        }
        
        return answer;
    }
}