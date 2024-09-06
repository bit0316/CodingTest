using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int size = num_list.Length;
        int[] answer = new int[size + 1];
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] = num_list[i];
        }
        answer[size] = answer[size - 1] > answer[size - 2] ? answer[size - 1] - answer[size - 2] : 2 * answer[size - 1];
        
        return answer;
    }
}