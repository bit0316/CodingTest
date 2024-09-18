using System;

public class Solution
{
    public int solution(string binomial)
    {
        string[] arr = binomial.Split();
        int answer = 0;
        
        if (arr[1] == "+")
        {
            answer = int.Parse(arr[0]) + int.Parse(arr[2]);
        }
        else if (arr[1] == "-")
        {
            answer = int.Parse(arr[0]) - int.Parse(arr[2]);
        }
        else
        {
            answer = int.Parse(arr[0]) * int.Parse(arr[2]);
        }
        
        return answer;
    }
}