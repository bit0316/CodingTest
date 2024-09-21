using System;

public class Solution
{
    public int solution(int[] sides)
    {
        int answer = 0;
        int min = Math.Abs(sides[0] - sides[1]) + 1;
        int max = sides[0] + sides[1] - 1;
        
        answer = max - min + 1;
        
        return answer;
    }
}