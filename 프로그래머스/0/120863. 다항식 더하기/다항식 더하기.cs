using System;

public class Solution
{
    public string solution(string polynomial)
    {
        string[] arr = polynomial.Split();
        int size = arr.Length;
        string answer = "";
        int numX = 0;
        int numA = 0;
        
        for (int i = 0; i < size; i += 2)
        {
            if (arr[i].Contains('x'))
            {
                arr[i] = arr[i].Replace("x", "");
                numX += arr[i] == "" ? 1 : int.Parse(arr[i]);
            }
            else
            {
                numA += int.Parse(arr[i]);
            }
        }
        
        if (numX > 0 && numA > 0)
        {
            answer = numX == 1 ? $"x + {numA}" : $"{numX}x + {numA}";
        }
        else if (numX > 0)
        {
            answer = numX == 1 ? "x" : $"{numX}x";
        }
        else
        {
            answer = $"{numA}";
        }
        
        return answer;
    }
}