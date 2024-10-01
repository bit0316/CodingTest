using System;

public class Solution
{
    public int solution(int n, int m, int[] section)
    {
        bool[] unpaint = new bool[n + 1];
        int answer = 0;
        
        foreach (int index in section)
        {
            unpaint[index] = true;
        }
        
        for (int i = 1; i <= n; ++i)
        {
            if (unpaint[i])
            {
                answer++;
                if (i > n - m)
                {
                    break;
                }
                for (int j = i + m - 1; j >= i; --j)
                {
                    unpaint[j] = false;
                }
            }
        }
        
        return answer;
    }
}