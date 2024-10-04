using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string today, string[] terms, string[] privacies)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        List<int> list = new List<int>();
        int size = privacies.Length;
        int month = 12;
        int day = 28;
        int[] answer;
        int[] date;
        int todayDays;
        int privacyDays;
        string[] str;
        
        date = Array.ConvertAll(today.Split('.'), int.Parse);
        todayDays = (date[0] * month + date[1]) * day + date[2];

        foreach (string term in terms)
        {
            str = term.Split();
            dict.Add(str[0], int.Parse(str[1]) * day);
        }
        
        for (int i = 0; i < size; ++i)
        {
            str = privacies[i].Split();
            date = Array.ConvertAll(str[0].Split('.'), int.Parse);
            privacyDays = (date[0] * month + date[1]) * day + date[2];
            if (todayDays - privacyDays >= dict[str[1]])
            {
                list.Add(i + 1);
            }
        }
        answer = list.ToArray();
        
        return answer;
    }
}