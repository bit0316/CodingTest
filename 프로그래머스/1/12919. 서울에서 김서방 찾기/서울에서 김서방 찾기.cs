public class Solution
{
    public string solution(string[] seoul)
    {
        int size = seoul.Length;
        string answer = "";
        
        for (int i = 0; i < size; ++i)
        {
            if (seoul[i] == "Kim")
            {
                answer = $"김서방은 {i}에 있다";
                break;
            }
        }
        
        return answer;
    }
}