using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        string reverse = "";
        int size = pat.Length;
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            reverse += pat[i] == 'A' ? 'B' : 'A';
        }
        answer = myString.Contains(reverse) ? 1 : 0;
        
        return answer;
    }
}