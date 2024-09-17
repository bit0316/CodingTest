using System;

public class Solution
{
    public int solution(int num, int k)
    {
        int answer = -1;
        int index = num.ToString().Length;
        
        while (num > 0)
        {
            if (num % 10 == k)
            {
                answer = index;
            }
            num /= 10;
            index--;
        }
        
        return answer;
    }
}