using System;

public class Solution
{
    public string[] solution(string[] quiz)
    {
        int size = quiz.Length;
        string[] answer = new string[size];
        string[] arr;
        
        for (int i = 0; i < size; ++i)
        {
            arr = quiz[i].Split();
            if (arr[1] == "+")
            {
                answer[i] = int.Parse(arr[0]) + int.Parse(arr[2]) == int.Parse(arr[4]) ? "O" : "X";
            }
            else
            {
                answer[i] = int.Parse(arr[0]) - int.Parse(arr[2]) == int.Parse(arr[4]) ? "O" : "X";
            }
        }
        
        return answer;
    }
}