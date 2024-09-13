using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        string[] arr = s.Split();
        int size = arr.Length;
        
        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == "Z")
            {
                answer -= int.Parse(arr[i - 1]);
            }
            else
            {
                answer += int.Parse(arr[i]);
            }
        }
        
        return answer;
    }
}