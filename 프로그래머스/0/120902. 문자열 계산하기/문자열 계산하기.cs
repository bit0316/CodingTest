using System;

public class Solution
{
    public int solution(string my_string)
    {
        string[] arr = my_string.Split();
        int size = arr.Length;
        int answer = int.Parse(arr[0]);
        
        for (int i = 1; i < size; i += 2)
        {
            answer += arr[i] == "+" ? int.Parse(arr[i + 1]) : -int.Parse(arr[i + 1]);
        }
        
        return answer;
    }
}