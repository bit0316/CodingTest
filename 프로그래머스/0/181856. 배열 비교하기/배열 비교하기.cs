using System;
using System.Linq;

public class Solution
{
    public int solution(int[] arr1, int[] arr2)
    {
        int size1 = arr1.Length;
        int size2 = arr2.Length;
        int sum1 = arr1.Sum();
        int sum2 = arr2.Sum();
        int answer = 0;
        
        if (size1 == size2)
        {
            if (sum1 > sum2)
            {
                answer = 1;
            }
            else if (sum1 < sum2)
            {
                answer = -1;
            }
        }
        else if (size1 > size2)
        {
            answer = 1;
        }
        else
        {
            answer = -1;
        }
        
        return answer;
    }
}