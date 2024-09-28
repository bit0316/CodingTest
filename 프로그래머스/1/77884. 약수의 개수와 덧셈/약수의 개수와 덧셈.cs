using System;

public class Solution
{
    public int solution(int left, int right)
    {
        int answer = 0;
        
        for (int i = left; i <= right; ++i)
        {
            answer += GetCount(i) % 2 == 0 ? i : -i;
        }
        
        return answer;
    }
    
    public int GetCount(int num)
    {
        int count = 0;
        
        for (int i = 1; i * i <= num; ++i)
        {
            if (i * i == num)
            {
                count++;
            }
            else if (num % i == 0)
            {
                count += 2;
            }
        }
        
        return count;
    }
}