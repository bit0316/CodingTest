using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n, int k)
    {
        List<long> list = new List<long>();
        string str = "";
        bool[] isPrime;
        int answer = 0;
        
        while (n > 0)
        {
            str += n % k;
            n /= k;
        }
        
        str = new string(str.Trim().Reverse().ToArray());
        foreach (string s in str.Split('0'))
        {
            if (s != "")
            {
                list.Add(long.Parse(s));
            }
        }
        foreach (long num in list)
        {
            if (IsPrime(num))
            {
                answer++;
            }
        }
        
        return answer;
    }
    
    public bool IsPrime(long num)
    {
        if (num == 1)
        {
            return false;
        }
        
        for (long i = 2; i * i <= num; ++i)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}