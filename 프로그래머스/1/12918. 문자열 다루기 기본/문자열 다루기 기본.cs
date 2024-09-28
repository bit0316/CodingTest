public class Solution
{
    public bool solution(string s)
    {
        int size = s.Length;
        bool answer = (size == 4 || size == 6) && int.TryParse(s, out int num);
        
        return answer;
    }
}