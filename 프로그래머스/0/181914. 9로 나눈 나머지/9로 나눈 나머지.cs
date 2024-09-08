using System;

public class Solution
{
    public int solution(string number)
    {
        int answer = 0;
        int sum = 0;
        int size = number.Length;
        
        for (int i = 0; i < size; ++i)
        {
            sum += int.Parse(number[i].ToString());
        }
        answer = sum % 9;
        
        return answer;
    }
}