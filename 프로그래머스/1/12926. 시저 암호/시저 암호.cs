public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";
        
        foreach (char ch in s)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                answer += (char)('a' + (ch - 'a' + n) % 26);
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                answer += (char)('A' + (ch - 'A' + n) % 26);
            }
            else
            {
                answer += ' ';
            }
        }
        
        return answer;
    }
}