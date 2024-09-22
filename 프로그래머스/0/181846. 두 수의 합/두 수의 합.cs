using System;

public class Solution
{
    public string solution(string a, string b)
    {
        int sizeA = a.Length;
        int sizeB = b.Length;
        int max = Math.Max(sizeA, sizeB);
        char[] arr = new char[max + 1];
        string answer = "";
        int numA, numB, sum;
        int carry = 0;
        
        for (int i = 0; i < max; i++)
        {
            numA = i < sizeA ? a[sizeA - 1 - i] - '0' : 0;
            numB = i < sizeB ? b[sizeB - 1 - i] - '0' : 0;
            sum = carry + numA + numB;
            
            arr[i] = (char)(sum % 10 + '0');
            carry = sum / 10;
        }
        arr[max] = carry > 0 ? (char)(carry + '0') : ' ';
        
        Array.Reverse(arr);
        answer = new string(arr).Trim();
        
        return answer;
    }
}