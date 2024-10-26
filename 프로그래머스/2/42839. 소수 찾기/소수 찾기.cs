using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string numbers)
    {
        HashSet<int> hash = new HashSet<int>();
        int size = numbers.Length;
        bool[] visited = new bool[size];
        int answer = 0;
        
        for (int i = 0; i < size; ++i)
        {
            GetNumber(i, size, "", numbers, visited, hash);
        }
        
        foreach (int num in hash)
        {
            if (num > 1 && IsPrime(num))
            {
                answer++;
            }
        }
        
        return answer;
    }
    
    public void GetNumber(int index, int size, string str, string numbers, bool[] visited, HashSet<int> hash)
    {
        if (index == size)
        {
            hash.Add(int.Parse(str));
            return;
        }
        
        for (int i = 0; i < size; ++i)
        {
            if (!visited[i])
            {
                visited[i] = true;
                GetNumber(index + 1, size, str + numbers[i], numbers, visited, hash);
                visited[i] = false;
            }
        }
    }
    
    public bool IsPrime(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        
        for (int i = 2; i <= sqrt; ++i)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}