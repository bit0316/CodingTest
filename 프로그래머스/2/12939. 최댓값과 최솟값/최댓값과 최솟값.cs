using System;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        int[] arr = Array.ConvertAll(s.Split(), int.Parse);
        string answer = $"{arr.Min()} {arr.Max()}";
        
        return answer;
    }
}