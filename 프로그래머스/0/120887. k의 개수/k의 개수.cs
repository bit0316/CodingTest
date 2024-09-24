using System;

public class Solution
{
    public int solution(int i, int j, int k)
    {
        int answer = 0;
        int num;
        
        for (int index = i; index <= j; ++index)
        {
            num = index;
            while (num > 0)
            {
                if (num % 10 == k)
                {
                    answer++;
                }
                num /= 10;
            }
        }
        
        return answer;
    }
}