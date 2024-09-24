using System;

public class Solution
{
    public string solution(string bin1, string bin2)
    {
        int numA = Convert.ToInt32(bin1, 2);
        int numB = Convert.ToInt32(bin2, 2);
        int sum = numA + numB;
        string answer = Convert.ToString(sum, 2);
        
        return answer;
    }
}