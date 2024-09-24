using System;

public class Solution
{
    public int solution(string[] order)
    {
        int answer = 0;
        
        foreach (string coffee in order)
        {
            answer += coffee.Contains("cafelatte") ? 5000 : 4500;
        }
        
        return answer;
    }
}