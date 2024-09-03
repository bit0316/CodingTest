using System;

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 0;
        int numA = int.Parse(a.ToString() + b.ToString());
        int numB = 2 * a * b;
        
        answer = Math.Max(numA, numB);
        
        return answer;
    }
}