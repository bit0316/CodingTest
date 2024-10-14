public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int temp = 1;
        
        for (int i = 0; i < n; ++i)
        {
            (temp, answer) = (answer, temp + answer);
            answer %= 1234567;
        }
        
        return answer;
    }
}