public class Solution
{
    public string solution(int n)
    {
        int count = n / 2;
        string answer = "";
        
        for (int i = 0; i < count; ++i)
        {
            answer += "수박";
        }
        if (n % 2 == 1)
        {
            answer += "수";
        }
        
        return answer;
    }
}