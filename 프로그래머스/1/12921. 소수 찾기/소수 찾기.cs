public class Solution
{
    public int solution(int n)
    {
        bool[] isPrime = GetPrime(n);
        int answer = 0;
        
        for (int i = 2; i <= n; ++i)
        {
            if (isPrime[i])
            {
                answer++;
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