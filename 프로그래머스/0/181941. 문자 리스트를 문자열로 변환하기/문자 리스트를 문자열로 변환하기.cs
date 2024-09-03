using System;

public class Solution
{
    public string solution(string[] arr)
    {
        string answer = "";
        int size = arr.Length;
        
        for (int i = 0; i < size; ++i)
        {
            answer += arr[i];
        }
        
        return answer;
    }
}