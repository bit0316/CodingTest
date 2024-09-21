using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int except = 5;
        int size = num_list.Length;
        int[] answer = new int[size - except];
        
        Array.Sort(num_list);
        for (int i = except; i < size; ++i)
        {
            answer[i - except] = num_list[i];
        }
        
        return answer;
    }
}