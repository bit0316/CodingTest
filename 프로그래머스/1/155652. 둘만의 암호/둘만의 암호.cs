using System;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        int size = s.Length;
        char[] arr = s.ToCharArray();
        bool[] isSkip = new bool[26];
        string answer = "";
        int count;
        
        foreach (char ch in skip)
        {
            isSkip[ch - 'a'] = true;
        }
        
        for (int i = 0; i < size; ++i)
        {
            count = 0;
            while (count < index)
            {
                arr[i]++;
                if (arr[i] > 'z')
                {
                    arr[i] = 'a';
                }
                if (!isSkip[arr[i] - 'a'])
                {
                    count++;
                }
            }
        }
        answer = new string(arr);
        
        return answer;
    }
}