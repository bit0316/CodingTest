using System;

public class Solution
{
    public string[] solution(string[] strArr)
    {
        int size = strArr.Length;
        string[] answer = new string[size];
        
        for (int i = 0; i < size; ++i)
        {
            answer[i] = i % 2 == 0 ? strArr[i].ToLower() : strArr[i].ToUpper();
        }
        
        return answer;
    }
}