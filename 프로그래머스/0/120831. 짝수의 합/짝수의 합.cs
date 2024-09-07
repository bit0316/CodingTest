using System;

public class Solution
{
    public int solution(int n)
    {
        int count = n / 2;
        int answer = count * (count + 1);
        
        return answer;
    }
}