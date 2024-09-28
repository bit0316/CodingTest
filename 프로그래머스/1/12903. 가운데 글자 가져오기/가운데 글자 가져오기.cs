public class Solution
{
    public string solution(string s)
    {
        int size = s.Length;
        string answer = "";
        
        if (size % 2 == 0)
        {
            answer += s[size / 2 - 1];
        }
        answer += s[size / 2];
        
        return answer;
    }
}