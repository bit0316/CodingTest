using System;

public class Solution
{
    public long solution(long n)
    {
        char[] arr = n.ToString().ToCharArray();
        long answer = 0;
        
        Array.Sort(arr);
        Array.Reverse(arr);
        answer = long.Parse(new string(arr));
        
        return answer;
    }
}