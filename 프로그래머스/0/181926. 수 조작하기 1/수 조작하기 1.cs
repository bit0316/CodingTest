using System;

public class Solution
{
    public int solution(int n, string control)
    {
        int answer = 0;
        int size = control.Length;
        
        for (int i = 0; i < size; ++i)
        {
            switch(control[i])
            {
                case 'w':
                    n++;
                    break;
                case 's':
                    n--;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
            }
        }
        answer = n;
        
        return answer;
    }
}