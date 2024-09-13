using System;
using System.Linq;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        string[] answer = new string[] { };
        int left = Array.IndexOf(str_list, "l");
        int right = Array.IndexOf(str_list, "r");

        if (left == -1)
        {
            left = int.MaxValue;
        }
        if (right == -1)
        {
            right = int.MaxValue;
        }

        if (left < right)
        {
            answer = str_list.Take(left).ToArray();
        }
        else if (left > right)
        {
            answer = str_list.Skip(right + 1).ToArray();
        }
        
        return answer;
    }
}