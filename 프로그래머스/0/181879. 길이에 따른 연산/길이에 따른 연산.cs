using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int point = 10;
        int size = num_list.Length;
        int answer = 0;
        
        if (size > point)
        {
            foreach (int num in num_list)
            {
                answer += num;
            }
        }
        else
        {
            answer = 1;
            foreach (int num in num_list)
            {
                answer *= num;
            }
        }
        
        return answer;
    }
}