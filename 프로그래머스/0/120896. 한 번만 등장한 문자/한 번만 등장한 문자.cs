using System;

public class Solution
{
    public string solution(string s)
    {
        int size = 26;
        int[] arr = new int[26];
        string answer = "";
        
        foreach (char ch in s)
        {
            arr[ch - 'a']++;
        }
        
        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == 1)
            {
                answer += Convert.ToChar('a' + i);
            }
        }
        
        return answer;
    }
}