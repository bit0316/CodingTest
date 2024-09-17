using System;

public class Solution
{
    public string solution(string myString, string pat)
    {
        string answer = myString.Replace(pat, "_");
        int size = answer.Length;
        int index = size - 1;
        
        while (index >= 0)
        {
            if (answer[index] == '_')
            {
                break;
            }
            index--;
        }
        answer = answer.Substring(0, index + 1);
        answer = answer.Replace("_", pat);
        
        return answer;
    }
}