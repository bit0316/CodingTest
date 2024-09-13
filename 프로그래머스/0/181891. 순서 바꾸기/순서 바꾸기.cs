using System;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int size = num_list.Length;
        int[] answer = new int[size];
        int index = 0;
        
        for (int i = n; i < size; ++i)
        {
            answer[index++] = num_list[i];
        }
        for (int i = 0; i < n; ++i)
        {
            answer[index++] = num_list[i];
        }
        
        return answer;
    }
}