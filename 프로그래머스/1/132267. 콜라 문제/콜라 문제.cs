using System;

public class Solution
{
    public int solution(int a, int b, int n)
    {
        int answer = 0;
        int remain;
        
        while (n >= a)
        {
            remain = n / a * b;
            answer += remain;
            n = n % a + remain;
        }
        
        return answer;
    }
}