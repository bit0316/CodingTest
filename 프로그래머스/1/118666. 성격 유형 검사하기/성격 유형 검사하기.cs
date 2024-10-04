using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>
        {
            { 'R', 0 }, { 'C', 1 }, { 'J', 2 }, { 'A', 3 },
            { 'T', 4 }, { 'F', 5 }, { 'M', 6 }, { 'N', 7 }
        };
        int[] arr = new int[8];
        int size = survey.Length;
        string answer = "";
        
        for (int i = 0; i < size; ++i)
        {
            arr[dict[survey[i][0]]] += choices[i] - 4;
            Console.WriteLine($"{survey[i][0]} : {choices[i]}");
        }
        
        answer += arr[0] <= arr[4] ? 'R' : 'T';
        answer += arr[1] <= arr[5] ? 'C' : 'F';
        answer += arr[2] <= arr[6] ? 'J' : 'M';
        answer += arr[3] <= arr[7] ? 'A' : 'N';
        
        return answer;
    }
}