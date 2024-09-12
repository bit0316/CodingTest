using System;

public class Solution
{
    public string solution(string my_string)
    {
        string[] vowels = { "a", "e", "i", "o", "u" };
        string answer = my_string;
        
        foreach (string vowel in vowels)
        {
            answer = answer.Replace(vowel, "");
        }
        
        return answer;
    }
}