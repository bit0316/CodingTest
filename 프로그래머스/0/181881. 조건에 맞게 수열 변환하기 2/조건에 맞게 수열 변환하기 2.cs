using System;

public class Solution
{
    public int solution(int[] arr)
    {
        int point = 50;
        int size = arr.Length;
        int answer = 0;
        int count;

        while (true)
        {
            count = 0;
            for (int i = 0; i < size; ++i)
            {
                if (arr[i] >= point && arr[i] % 2 == 0)
                {
                    arr[i] = arr[i] / 2;
                }
                else if (arr[i] < point && arr[i] % 2 == 1)
                {
                    arr[i] = arr[i] * 2 + 1;
                }
                else
                {
                    count++;
                }
            }
            if (count == size)
            {
                break;
            }
            answer++;
        }
        
        return answer;
    }
}