using System;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int size = absolutes.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            answer += signs[i] ? absolutes[i] : - absolutes[i];
        }
        
        return answer;
    }
}