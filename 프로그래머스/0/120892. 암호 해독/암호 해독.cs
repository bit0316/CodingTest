using System;

public class Solution
{
    public string solution(string cipher, int code)
    {
        int size = cipher.Length;
        string answer = "";
        
        for (int i = code - 1; i < size; i += code)
        {
            answer += cipher[i];
        }
        
        return answer;
    }
}