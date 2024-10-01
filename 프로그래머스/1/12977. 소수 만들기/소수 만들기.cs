using System;
using System.Linq;

class Solution
{
    public int solution(int[] nums)
    {
        int size = nums.Length;
        int max = nums.Max();
        bool[] isPrime = GetPrime(3 * max);
        int answer = 0;
        int sum;
        
        for (int i = 0; i < size - 2; ++i)
        {
            for (int j = i + 1; j < size - 1; ++j)
            {
                sum = nums[i] + nums[j];
                for (int k = j + 1; k < size; ++k)
                {
                    if (isPrime[sum + nums[k]])
                    {
                        answer++;
                    }
                }
            }
        }
        
        return answer;
    }
    
    public bool[] GetPrime(int size)
    {
        bool[] isPrime = new bool[size + 1];
        
        for (int i = 2; i <= size; ++i)
        {
            isPrime[i] = true;
        }
        
        for (int i = 2; i * i <= size; ++i)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= size; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
        
        return isPrime;
    }
}