using System;

public class Solution
{
    public int[] solution(string[] strlist)
    {
        int size = strlist.Length;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] = strlist[i].Length;
        }
        
        return answer;
    }
}