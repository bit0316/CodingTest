using System;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int[] answer = new int[2];
        int gcd;
        
        answer[0] = numer1 * denom2 + numer2 * denom1;
        answer[1] = denom1 * denom2;
        
        gcd = answer[0] > answer[1] ? GetGCD(answer[0], answer[1]) : GetGCD(answer[1], answer[0]);
        answer[0] /= gcd;
        answer[1] /= gcd;
        
        return answer;
    }
    
    public int GetGCD(int num1, int num2)
    {
        int remain = num1 % num2;
        
        return remain != 0 ? GetGCD(num2, remain) : num2;
    }
}