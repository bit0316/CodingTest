using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        bool[] isComposite = new bool[n + 1];
        
        for (int i = 2; i * i <= n; ++i)
        {
            if (!isComposite[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isComposite[j] = true;
                }
            }
        }
        
        for (int i = 4; i <= n; ++i)
        {
            if (isComposite[i])
            {
                answer++;
            }
        }
        
        return answer;
    }
}