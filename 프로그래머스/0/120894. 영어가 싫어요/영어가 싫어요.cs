using System;
using System.Collections.Generic;

public class Solution
{
    public long solution(string numbers)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"zero", "0"}, {"one", "1"}, {"two", "2"}, {"three", "3"}, {"four", "4"},
            {"five", "5"}, {"six", "6"}, {"seven", "7"}, {"eight", "8"}, {"nine", "9"}
        };
        long answer = 0;
        
        foreach (var item in dict)
        {
            numbers = numbers.Replace(item.Key, item.Value);
        }
        answer = long.Parse(numbers);
        
        return answer;
    }
}