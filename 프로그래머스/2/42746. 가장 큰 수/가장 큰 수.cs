using System;

public class Solution
{
    public string solution(int[] numbers)
    {
        string answer = "";
        string xy, yx;
        
        Array.Sort(numbers, (x, y) =>
        {
            xy = x.ToString() + y.ToString();
            yx = y.ToString() + x.ToString();
            
            return yx.CompareTo(xy);
        });
        answer = string.Join("", numbers);
        
        return answer.Trim('0') == "" ? "0" : answer;
    }
}