using System;

public class Solution
{
    public string solution(int age)
    {
        string answer = "";
        int size = age.ToString().Length;
        char[] arr = new char[size];
        
        for (int i = size - 1; i >= 0; --i)
        {
            arr[i] += (char)('a' + age % 10);
            age /= 10;
        }
        answer = new string(arr);
        
        return answer;
    }
}