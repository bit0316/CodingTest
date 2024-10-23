using System;

public class Solution
{
    public int solution(int storey)
    {
        int answer = 0;
        int count;
        
        while (storey > 0)
        {
            count = storey % 10;
            if (count > 5 || (count == 5 && storey % 100 >= 50))
            {
                storey += 10;
                count = 10 - count;
            }
            answer += count;
            storey /= 10;
        }
        
        return answer;
    }
}