using System;

public class Solution
{
    public int[] solution(string myString)
    {
        string[] arr = myString.Split('x');
        int size = arr.Length;
        int[] answer = new int[size];
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] = arr[i].Length;
        }
        
        return answer;
    }
}