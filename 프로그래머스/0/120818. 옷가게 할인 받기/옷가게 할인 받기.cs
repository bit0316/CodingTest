using System;

public class Solution
{
    public int solution(int price)
    {
        int answer = price;
        
        if (price >= 500000)
        {
            answer = price * 4 / 5;
        }
        else if (price >= 300000)
        {
            answer = price * 9 / 10;
        }
        else if (price >= 100000)
        {
            answer = price * 19 / 20;
        }
        
        return answer;
    }
}