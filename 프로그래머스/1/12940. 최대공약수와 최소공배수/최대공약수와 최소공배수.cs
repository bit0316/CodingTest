using System;

public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];
        int min = Math.Min(n, m);
        int max = Math.Max(n, m);
        
        answer[0] = GetGCD(max, min);
        answer[1] = GetLCM(max, min, answer[0]);
        
        return answer;
    }
    
    public int GetGCD(int numA, int numB)
    {
        while (numB > 0)
        {
            (numA, numB) = (numB, numA % numB);
        }
        
        return numA;
    }
    
    public int GetLCM(int numA, int numB, int gcd)
    {
        return numA * numB / gcd;
    }
}