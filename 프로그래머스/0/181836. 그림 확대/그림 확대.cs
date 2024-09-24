using System;

public class Solution
{
    public string[] solution(string[] picture, int k)
    {
        int size = picture.Length;
        string[] answer = new string[size * k];
        string strPoint = "";
        string strX = "";
        string line;
        
        for (int i = 0; i < k; ++i)
        {
            strPoint += ".";
            strX += "x";
        }
        
        for (int i = 0; i < size; ++i)
        {
            line = picture[i];
            line = line.Replace(".", strPoint);
            line = line.Replace("x", strX);
            for (int j = i * k; j < i * k + k; ++j)
            {
                answer[j] = line;
            }
        }
        
        return answer;
    }
}