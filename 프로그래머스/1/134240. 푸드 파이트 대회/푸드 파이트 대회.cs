using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(int[] food)
    {
        List<char> list = new List<char>();
        int size = food.Length;
        string answer = "";
        
        for (int i = 1; i < size; ++i)
        {
            for (int j = food[i] / 2; j > 0; --j)
            {
                list.Add((char)(i + '0'));
            }
        }
        answer += new string(list.ToArray()) + '0';
        list.Reverse();
        answer += new string(list.ToArray());
        
        return answer;
    }
}