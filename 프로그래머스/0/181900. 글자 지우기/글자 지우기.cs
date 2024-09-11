using System;

public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        string answer = "";
        char[] arr = my_string.ToCharArray();
        int size = indices.Length;
        
        for (int i = 0; i < size; ++i)
        {
            arr[indices[i]] = ' ';
        }
        answer = new string(arr).Replace(" ", "");
        
        return answer;
    }
}