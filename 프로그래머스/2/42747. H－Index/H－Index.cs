using System;

public class Solution
{
    public int solution(int[] citations)
    {
        int size = citations.Length;
        int answer = size;
        
        Array.Sort(citations);
        for (int i = 0; i < size; ++i)
        {
            if (citations[i] >= answer)
            {
                break;
            }
            answer--;
        }
        
        return answer;
    }
}