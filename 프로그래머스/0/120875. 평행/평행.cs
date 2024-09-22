using System;

public class Solution
{
    public int solution(int[,] dots)
    {
        int answer = 0;
        
        if (IsValid(dots, 0, 1, 2, 3) || IsValid(dots, 0, 2, 1, 3) || IsValid(dots, 0, 3, 1, 2))
        {
            answer = 1;
        }
        
        return answer;
    }
    
    public bool IsValid(int[,] dots, int a, int b, int c, int d)
    {
        double gradientA = (double)(dots[a, 1] - dots[b, 1]) / (dots[a, 0] - dots[b, 0]);
        double gradientB = (double)(dots[c, 1] - dots[d, 1]) / (dots[c, 0] - dots[d, 0]);
        
        if (gradientA == gradientB)
        {
            return true;
        }
        return false;
    }
}