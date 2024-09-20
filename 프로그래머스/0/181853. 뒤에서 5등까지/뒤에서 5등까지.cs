using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int size = 5;
        int[] answer = new int[size];
        
        Array.Sort(num_list);
        for (int i = 0; i < size; ++i)
        {
            answer[i] = num_list[i];
        }
        
        return answer;
    }
}